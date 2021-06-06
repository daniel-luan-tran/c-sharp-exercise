using System;

namespace DataTypeDef
{
	struct PHANSO
	{
		public int TuSo;
		public int MauSo;
	}

	public static PHANSO NhapPhanSo()
	{
		Console.WriteLine("Nhap tu so: ");
		PHANSO phanso.TuSo = int.Parse(Console.ReadLine());

		Console.WriteLine("Nhap mau so: ");
		PHANSO phanso.MauSo = int.Parse(Console.ReadLine());

		Console.WriteLine{$"Ta co phan so: {phanso.Tu} / {phanso.Mau}"};

		return phanso;
	}

	public static PHANSO SoSanh(PHANSO A, PHANSO B)
	{
		if (A.TuSo * B.MauSo > B.TuSo * A.MauSo)
		{
			Console.WriteLine("Phan so A > phan so B");
		}

		else if (A.TuSo * B.MauSo = B.TuSo * A.MauSo)
		{
			Console.WriteLine("2 phan so bang nhau");
		}
		else
		{
			Console.WriteLine("Phan so A < phan so B");
		}
	}
}