using System;

namespace Mang2Chieu_Exercises
{
	class Bai_358
	{
		public static bool Check(int[,] array, int dong)
		{
			bool check = false;
			for (int j = 0; j < array.GetLength(1); j++)
			{
				if (array[dong, j] % 2 == 0)
				{
					check = true;
				}
			}
			return check;
		}

		public static void RowEvenCheck(int[,] array)
		{
			for (int i = 0; i < array.GetLength(0); i++)
			{
				if (Check(array, i) ==  true)
				{
					Console.WriteLine($"Dong {i+1} co so chan");
				}
			}
		}
	}
}