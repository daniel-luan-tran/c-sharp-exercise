using System;

namespace DataTypeDef
{
	class Chu_Vi_Tam_Giac
	{
		struct DIEM
		{
			public int X;
			public int Y;
		}

		struct TG
		{
			public DIEM A;
			public DIEM B;
			public DIEM C;
		}

		public static DIEM NhapDiem()
		{
			DIEM dinh;

			Console.WriteLine("Nhap toa do X: ");
			dinh.X = int.Parse(Console.ReadLine());

			Console.WriteLine("Nhap toa do Y: ");
			dinh.Y = int.Parse(Console.ReadLine());

			return dinh;
		}

		public static TG NhapTamGiac()
		{
			TG tg;

			Console.WriteLine("Nhap diem A: ");
			tg.A = NhapDiem();

			Console.WriteLine("Nhap diem B: ");
			tg.B = NhapDiem();			

			Console.WriteLine("Nhap diem C: ");
			tg.C = NhapDiem();	

			return tg;	
		}

		public static TinhKhoangCach(DIEM A, DIEM B)
		{
			double d;

			d = Math.Sqrt( Math.Pow( (A.X - B.X), 2 ) + Math.Pow( (A.Y - B.Y), 2 ) );

			return d;
		}

		public static double ChuViTamGiac(TG tg)
		{

			tg.A = NhapTamGiac();
			tg.B = NhapTamGiac();
			tg.C = NhapTamGiac();

			double c, a, b;

			c = TinhKhoangCach(tg.A, tg.B);
			a = TinhKhoangCach(tg.B, tg.C);
			b = TinhKhoangCach(tg.C, tg.A);

			double chuvi;
			chuvi = a + b + c;

			Console.WriteLine($"Chu vi tam giac: {chuvi}");

			return chuvi;
		}
	}
}