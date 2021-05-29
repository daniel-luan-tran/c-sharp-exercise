using System;

namespace Mang2Chieu_Exercises
{
	class Bai_330
	{
		public static void LayPhanNguyen(double[,] array)
		{
			int i,j;
			for (i = 0; i < array.GetLength(0); i++)
			{
				for (j = 0; j < array.GetLength(1); j++)
				{
					array[i,j] = Math.Round(array[i,j]);
				}
			}
			XL_MaTran.Xuatmatran_Sothuc(array);
		}
	}
}
