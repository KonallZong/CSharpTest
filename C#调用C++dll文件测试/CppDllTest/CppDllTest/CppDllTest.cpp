// CppDllTest.cpp: 定义 DLL 应用程序的导出函数。
//

#include "stdafx.h"
#include"CppDllTest.h"
#include<ctime>

double _stdcall DoLoop(int loopCount)
{
	clock_t begin, end;
	begin = clock();
	while (true)
	{
		end = clock();
		if(((double)(end-begin)/1000)>1)
			break;;

	}
	return (double)(end - begin) / 1000;
}

double _stdcall DoLoopTime(int loopCount)
{	
	clock_t begin, end;
	long values=0;
	begin = clock();
	for (int i=0;i<loopCount;i++)
	{
		for (int j = 0; j < loopCount; j++)
		{
			long lvalue = 0;
			for (int k = 0; k < loopCount; k++)
			{
				lvalue++;
			}
		
			values++;
		}
	}

	while (true)
	{
		end = clock();
		if ((end - begin) > 200)
			break;
	}
	return (double)(end - begin) / 1000.0;
}
