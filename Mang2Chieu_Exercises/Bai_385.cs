using System;

namespace Mang2Chieu_Exercises
{
	class Bai_385
	{
		public static int TinhTongDong(int[,] array, int Dong_i)
		{
			int S = 0;
			for (int j = 0; j < array.GetLength(1); j++)
			{
				S = S + array[Dong_i,j];
			}
			return S;
		}

		public static void DongCoTongLonNhat(int[,] array)
		{
			int Smax = TinhTongDong(array, 0);

			//Tim gia tri tong dong lon nhat Smax
			for (int Dong_i = 0; Dong_i < array.GetLength(0); Dong_i++)
			{
				if(TinhTongDong(array, Dong_i) > Smax)
				{
					Smax = TinhTongDong(array, Dong_i);
				}
			}

			//Liet ke cac dong co tong dong lon nhat
			Console.Write("Cac dong co tong lon nhat la dong thu: ");
			for (int Dong_i = 0; Dong_i < array.GetLength(0); Dong_i++)
			{
				if(TinhTongDong(array, Dong_i) == Smax)
				{
					Console.Write($"{Dong_i+1}");
				}
			}
			Console.WriteLine();
		}
	}
}