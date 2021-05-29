using System;

namespace Mang2Chieu_Exercises
{
	class Bai_328
	{
		public static double Multi(double[,] array)
		{
			double multi = 1;
			int i,j;
			for (i = 0; i < array.GetLength(0); i++)
			{
				for (j = 0; j < array.GetLength(1); j++)
				{
					multi = multi * array[i,j];
				}
			}
			Console.WriteLine($"Tich la: {multi}");
			return multi;
		}

		public static double AvrMulti(double[,] array)
		{
			double n = array.GetLength(0) * array.GetLength(1);
			double avrmulti = Math.Pow(Multi(array), (1 / n));
			Console.WriteLine($"Trung binh nhan: {avrmulti}");
			return avrmulti;
		}
	}
}