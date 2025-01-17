﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using MEFTestDemo;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace MEFTestDemo
{

   public class CTest
    {
        [ImportMany]
        public List<Lazy<ILogger, IMetaData>> pluginList=new List<Lazy<ILogger, IMetaData>>();

        public CTest(string filePath)
        {
           Build(filePath);
        }

        private void Build(string filePath)
        {
            AggregateCatalog aggregateCatalog = new AggregateCatalog();
            DirectoryCatalog directoryCatalog = new DirectoryCatalog(filePath);
            aggregateCatalog.Catalogs.Add(directoryCatalog);

            //AssemblyCatalog assemblyCatalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            var container = new CompositionContainer(aggregateCatalog);
            container.ComposeParts(this);
        }

        public string[] Names
        {
            get {
                List<string> _names = new List<string>();
                foreach (var item in pluginList)
                {
                    _names.Add(item.Metadata.Guid);
                }
                return _names.ToArray();
            }
        }

        public ILogger GetClass(string className)
        {
            if (Names.Contains(className))
            {
                var plugin = pluginList.Where(o=>o.Metadata.Guid.ToLower()==className.ToLower())
                    .Select(p=> p.Value)
                    .FirstOrDefault();
                //return plugin as ILogger;
                return (ILogger)plugin;
            }
            return null;
        }
    }
}
