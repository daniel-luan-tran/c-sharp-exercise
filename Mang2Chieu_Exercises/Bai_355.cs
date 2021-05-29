using System;

namespace Mang2Chieu_Exercises
{
	class Bai_355
	{
		public static bool Check(double[,] array, int dong_i)
		{
			bool check = true;
			for (int j = 0; j < array.GetLength(1); j++)
			{
				if(array[dong_i,j] > 0)
				{
					check = false;
				}
			}
			return check;
		}

		public static void RowAllNegativeCheck(double[,] array)
		{
			bool flag = false;
			for (int i = 0; i < array.GetLength(0); i++)
			{
				if(Check(array,i) == true)
				{
					flag = true;
					Console.WriteLine($"Dong thu {i+1} toan am");
				}
			}
			if (flag == false)
			{
				Console.WriteLine("Khong co dong nao toan am");
			}

		}
	}
}