using System;

namespace Mang2Chieu_Exercises
{
	class Bai_378
	{
		//Dem so luong lap lai cua moi gia tri trong mang
		public static int Count(double[,] array, double value)
		{
			int count = 0;
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					if (value == array[i,j])
					{
						count++;
					}
				} 
			}
			return count;
		}

		//Danh dau so luong duoc lap lai nhieu nhat
		public static int CountMax(double[,] array)
		{
			int countmax = 0;
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					if (Count(array, array[i,j]) > countmax)
					{
						countmax = Count(array, array[i,j]);
					}
				}
			}
			return countmax;
		}

		//Tim gia tri lap lai nhieu nhat
		public static void CountMaxValue(double[,] array)
		{
			Console.WriteLine($"Gia tri xuat hien nhieu nhat la:");
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					if (Count(array, array[i,j]) == CountMax(array))
					{
						Console.WriteLine($"array[{i}, {j}]: {array[i,j]}");
					}
				}
			}
		}
	}
}