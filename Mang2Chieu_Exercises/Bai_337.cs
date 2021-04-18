using System;

namespace Mang2Chieu_Exercises
{
	class Bai_337 //Dem so luong chu so trong ma tran so nguyen duong
	{
		public static void NumberCount(uint[,] arr)
		{
			int i, j;
			int count = 0;
			for (i = 0; i < arr.GetLength(0); i++)
			{
				for (j = 0; j < arr.GetLength(1); j++)
				{
					count++;
				}
			}
			Console.WriteLine($"Co {count} chu so trong ma tran so nguyen");
		}
	}
}