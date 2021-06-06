using System;

namespace Mang2Chieu_Exercises
{
	class Bai_369
	{
		public static void FirstPositive(double[,] array)
		{
			int flag = 0;
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					if(array[i,j] > 0)
					{
						Console.WriteLine($"So duong dau tien trong ma tran la: {array[i,j]}");
						flag++;
						break;
					}
				}
				if (flag > 0)
                {
					break;
                }
			}
		}
	}
}