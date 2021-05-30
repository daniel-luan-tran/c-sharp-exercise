using System;

namespace Mang2Chieu_Exercises
{
	class Bai_367
	{
		public static void MaxFilter(double[,] array)
		{
			double Max = array[0,0];
			int i,j;
			for (i = 0; i < array.GetLength(0); i++)
			{
				for (j = 0; j < array.GetLength(1); j++)
				{
					if (array[i,j] > Max)
					{
						Max = array[i,j];
					}
				}
			}
			Console.WriteLine($"Gia tri lon nhat trong ma tran la: {Max}");
		}
	}
}