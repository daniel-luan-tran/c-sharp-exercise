using System;

namespace Mang2Chieu_Exercises
{
	class Bai_341
	{
		public static void EdgePositiveCount(double[,] array)
		{
			int count = 0;
			int dong_dau = 0;
			int dong_cuoi = array.GetLength(0) - 1;
			int cot_dau = 0;
			int cot_cuoi = array.GetLength(1) - 1;

			for (int j = 0; j < array.GetLength(1); j++)
			{
				if (array[dong_dau,j] > 0)
				{
					count++;
				}
			}
			for (int j = 0; j < array.GetLength(1); j++)
			{
				if (array[dong_cuoi,j] > 0)
				{
					count++;
				}
			}
			for (int i = 1; i < array.GetLength(0)-1; i++)
			{
				if (array[i,cot_dau] > 0)
				{
					count++;
				}
			}
			for (int i = 1; i < array.GetLength(0)-1; i++)
			{
				if (array[i,cot_cuoi] > 0)
				{
					count++;
				}
			}
			Console.WriteLine($"So luong so duong tren bien cua ma tran la: {count}");
		}
	}
}