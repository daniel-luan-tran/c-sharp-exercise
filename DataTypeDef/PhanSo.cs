using System;

namespace DataTypeDef
{
	class Phan_So
	{
		struct PhanSo
		{
			public int TuSo;
			public int MauSo;
		}

		public static PhanSo NhapXuatPhanSo()
		{
			PhanSo phanso;
			Console.WriteLine("Nhap tu so: ");
			phanso.TuSo = int.Parse(Console.Readline());

			Console.WriteLine("Nhap mau su: ");
			phanso.MauSo = int.Parse(Console.Readline());

			Console.WriteLine($"Phan so la: {tuso.TuSo} / {mauso.MauSo}");
			return phanso;
		}

		public static PhanSo TinhTongPhanSo(PhanSo A, PhanSo B)
		{
			PhanSo kq;
			kq.TuSo = A.TuSo * B.MauSo + B.TuSo * A.MauSo;
			kq.MauSo = A.MauSo * B.MauSo;

			Console.WriteLine("Ket qua tong 2 phan so: ");
			Console.WriteLine($"{kq.TuSo} / {kq.MauSo}");
			return kq;
		}
	}
}