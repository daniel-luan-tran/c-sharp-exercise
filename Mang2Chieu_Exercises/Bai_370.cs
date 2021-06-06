using System;

namespace Mang2Chieu_Exercises
{
	class Bai_370
	{
		public static void MaxNegative(double[,] array)
		{
			double Max_Negative = array[0,0];
			//Tim gia tri am dau tien
			bool flag = false;
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
                    if (array[i, j] < 0)
                    {
						flag = true;
                        Max_Negative = array[i, j];
						break;
                    }
                }
				if (flag == true)
                {
					break;
                }
            }

			//Tim gia tri am lon nhat
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					if (array[i,j] < 0)
                    {
						if (array[i, j] > Max_Negative)
						{
							Max_Negative = array[i, j];
						}
					}
                    else
                    {
                        continue;
                    }
                }
			}

			Console.WriteLine($"Gia tri am lon nhat la: {Max_Negative}");
		}
	}
}