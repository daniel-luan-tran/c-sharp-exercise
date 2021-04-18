using System;

namespace Mang2Chieu_Exercises
{
	class Bai_336 //Tan suat xuat hien cua gia tri x trong ma tran
	{
		public static void x_Count(double[,] arr)
		{
			int count = 0;
			int i, j;
			double x;
			Console.Write("Nhap vao so thuc x can tim: ");
			x = double.Parse(Console.ReadLine());

			for (i = 0; i < arr.GetLength(0); i++)
			{
				for (j = 0; j < arr.GetLength(0); j++)
                {
					if (x == arr[i, j])
                    {
						count++;
                    }
                }
			}
			if (count == 0)
			{
				Console.WriteLine("Khong xuat hien gia tri x nao trong ma tran so thuc");
			}
			else
			{
				Console.WriteLine($"Co {count} gia tri x trong ma tran so thuc!");
			}
		}
	}
}
