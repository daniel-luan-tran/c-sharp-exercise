using System;

namespace Mang2Chieu_Exercises
{
	class Bai_368
	{
		public static void SecondMaxFilter(double[,] array)
		{
			//Tim gai tri Max
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

			//Tim gia tri lon thu hai
			double SecondMax = array[0,0];
			for (i = 0; i < array.GetLength(0); i++)
			{
				for (j = 0; j < array.GetLength(1); j++)
				{
					if (array[i,j] == Max)
					{
						//Bo qua gia tri lon nhat
						continue;
					}
					else
					{
						if (array[i,j] > SecondMax)
						{
							SecondMax = array[i, j];
						}
					}
				}
			}
			Console.WriteLine($"Gia tri lon thu hai la: {SecondMax}");
		}
	}
}