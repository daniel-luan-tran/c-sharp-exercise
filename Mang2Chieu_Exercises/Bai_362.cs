using System;

namespace Mang2Chieu_Exercises
{
	class Bai_362
	{
		public static bool Check(double[,] array, int dong)
		{
			bool check = true;
			for (int j = 0; j < array.GetLength(1); j++)
			{
				for (int n = j + 1; n < array.GetLength(1); n++)
                {
					if (array[dong, j + 1] < array[dong, j])
					{
						check = false;
					}
				}
			}
			return check;
		}

		public static void RowAscendCheck(double[,] array)
		{
			bool flag = false;
			for (int i = 0; i < array.GetLength(0); i++)
			{
				if (Check(array, i) == true)
				{
					flag = true;
					Console.WriteLine($"Dong {i} tang dan");
				}
			}
			if (flag == false)
			{
				Console.WriteLine("Khong co dong nao co gia tri tang dan");
			}
		}
	}
}