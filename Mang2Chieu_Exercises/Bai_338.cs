using System;

namespace Mang2Chieu_Exercises
{
	class Bai_338
	{
		public static int RowPositiveCount(double[,] array, int dong_i)
		{
			int count = 0;
			int i = dong_i - 1;
			for (int j = 0; j < array.GetLength(1); j++)
			{
				if (array[i,j] > 0)
				{
					count++;
				}
			}
			Console.WriteLine($"So luong gia tri duong tren hang {dong_i} la: {count}");
			return count;
		}
	}
}