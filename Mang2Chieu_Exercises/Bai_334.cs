using System;

namespace Mang2Chieu_Exercises
{
	class Bai_334 //Dem so luong so thuc duong trong ma tran so thuc
	{
		public static void PositiveCount(double[,]arr)
		{
			int count = 0;
			int i, j;
			for (i = 0; i < arr.GetLength(0); i++)
            {
				for (j = 0; j < arr.GetLength(1); j++)
                {
					if (arr[i, j] > 0)
                    {
						count++;
                    }
                }
            }
			if (count == 0)
			{
				Console.WriteLine("Khong co so duong nao trong ma tran so thuc");
			}
			else
            {
				Console.WriteLine($"Co {count} so duong trong ma tran so thuc");
			}
		}
	}
}
