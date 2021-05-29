using System;

namespace Mang2Chieu_Exercises
{
	class Bai_357
	{
		public static bool Check(int[,] array, int dong_i)
		{
			bool check = true;
			for (int j = 0; j < array.GetLength(1); j++)
			{
				if (array[dong_i, j] <= 1)
				{
					check = false;
					continue;
				}
				for (int k = 2; k < array[dong_i,j]; k++)
                {
					if (array[dong_i, j] % k == 0)
					{
						check = false;
						continue;
					}
				}
			}
			return check;
		}

		public static void SoNguyenToRowFilter(int[,] array)
        {
			bool flag = false;
			for (int i = 0; i < array.GetLength(0); i++)
            {
				if (Check(array, i) == true)
                {
					flag = true;
					Console.WriteLine($"Dong thu {i+1} co so nguyen to");
                }
            }
			if (flag == false)
            {
				Console.WriteLine("Khong co dong nao chua so nguyen to");
            }
        }
	}
}