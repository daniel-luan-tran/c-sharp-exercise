using System;

namespace Mang2Chieu_Exercises
{
	class Bai_335 //Dem so luong so nguyen to trong ma tran so nguyen
	{
		public static void PrimeCount(int[,] arr)
		{
			int count = 0;
			int i, j;
			int k = 2;
			for (i = 0; i < arr.GetLength(0); i++)
			{
				for (j = 0; j < arr.GetLength(1); j++)
				{
					if (arr[i, j] == 2)
					{
						count++;
					}
					while (k < arr[i, j])
                    {
						if (arr[i, j] % k == 0)
                        {
							k++;
                        }
						else
                        {
							count++;
						}
					}
				}
			}
			if (count == 0)
            {
				Console.WriteLine("Khong co so nguyen to nao");
            }
			else
            {
				Console.WriteLine($"Co {count} so nguyen to trong ma tran so nguyen!");
            }
		}
	}
}
