using System;

namespace Mang2Chieu_Exercises
{
	class Bai_360
	{
		public static bool Check(int[,] array, int cot)
		{
			bool check = false;
			for (int i = 0; i < array.GetLength(0); i++)
			{
				if ( ( Math.Sqrt( array[i, cot] ) ).GetType() == typeof(int) )
				{
					check = true;
				}
			}
			return check;
		}

		public static void ColumnSquareNoCheck(int[,] array)
		{
			for ( int j = 0; j < array.GetLength(1); j++)
			{
				if (Check(array, j) == true)
				{
					Console.WriteLine($"Cot {j+1} co so chinh phuong");
				}
				else
                {
					Console.WriteLine($"Khong {j+1} co so chinh phuong");
                }
			}
		}
	}
}