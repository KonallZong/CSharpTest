﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomSerializationTest
{
    public partial class Form1 : Form
    {
        private SerializeObjInfoCtrl serialize_Bit;//二进制序列化
        public Form1()
        {
            InitializeComponent();
            serialize_Bit = new SerializeObjInfoCtrl();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Add(serialize_Bit);
            serialize_Bit.Dock = DockStyle.Fill;


            serialize_Bit.imagePath = System.Environment.CurrentDirectory + @"\Image\image1.png";
            serialize_Bit.filePath = System.Environment.CurrentDirectory + @"\File\File1.ccdq";
            serialize_Bit.serializeType = SerializeTypeEnum.BIT;
        }


    }
}
