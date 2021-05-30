using System;

namespace Mang2Chieu_Exercises
{
	class Bai_386
	{
		public static int TinhTongCot(int[,] array, int Cot_j)
		{
			int S = 0;
			for (int i = 0; i < array.GetLength(0); i++)
			{
				S = S + array[i,Cot_j];
			}
			return S;
		}

		public static void CotCoTongNhoNhat (int[,] array)
		{
			//Tim tong cot nho nhat
			int Smin = TinhTongCot(array, 0);
			for (int Cot_j = 0; Cot_j < array.GetLength(1); Cot_j++)
			{
				if(TinhTongCot(array,Cot_j) < Smin)
				{
					Smin = Smin + TinhTongCot(array, Cot_j);
				}
			}

			//Tim cac cot co tong nho nhat
			Console.Write("Cot co tong nho nhat la cot thu: ");
			for (int Cot_j = 0; Cot_j < array.GetLength(1); Cot_j++)
			{
				if(TinhTongCot(array,Cot_j) == Smin)
				{
					Console.Write($"{Cot_j} va tong do la {Smin}");
				}
			}
			Console.WriteLine();
		}
	}
}