using System;

namespace DataTypeDef
{
	class Tinh_Khoang_Cach
	{
		struct DIEM
		{
			public int X;
			public int Y;
		}

		public static DIEM NhapDiem()
		{
			Console.WriteLine("Nhap toa do X: ");
			DIEM diem.X = int.Parse(Console.ReadLine());

			Console.WriteLine("Nhap toa do Y: ");
			DIEM diem.Y = int.Parse(Console.ReadLine());

			Console.WriteLine($"Ta co toa do diem: ({diem.X},{diem.Y})")
			return diem;
		}

		public static double TinhKhoangCach(DIEM A, DIEM B)
		{
			//Khoang cach 2 diem A va B
			double d;

			DIEM A = NhapDiem();
			DIEM B = NhapDiem();

			d = Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2));

			Console.WriteLine($"Khoang cach 2 diem A va B la: {d}");
			return d;
		}
	}
}