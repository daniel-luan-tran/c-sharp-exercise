using System;

namespace Mang2Chieu_Exercises
{
	class Bai_387
	{
		public static int DemSoChanDong_i(int[,] array, int Dong_i)
		{
			int Dem = 0;
			for (int j = 0; j < array.GetLength(1); j++)
			{
				if(array[Dong_i,j] % 2 == 0)
				{
					Dem = Dem + 1;
				}
			}
			return Dem;
		}

		public static void DongCoNhieuSoChanNhat(int[,] array)
		{
			int Max = DemSoChanDong_i(array, 0);

			//Danh dau so luong so chan lon nhat
			for (int Dong_i = 0; Dong_i < array.GetLength(0); Dong_i++)
			{
				if(DemSoChanDong_i(array, Dong_i) > Max)
				{
					Max = DemSoChanDong_i(array, Dong_i);
				}
			}

			for (int Dong_i = 0; Dong_i < array.GetLength(0); Dong_i++)
            {
				if (DemSoChanDong_i(array, Dong_i) == Max)
                {
					Console.WriteLine($"Dong {Dong_i + 1} co nhieu so chan nhat va co {Max} so chan");
				}
				if (DemSoChanDong_i(array, Dong_i) == 0)
                {
					Console.WriteLine($"Dong {Dong_i + 1} khong co so chan");
				}
			}
		}
	}
}