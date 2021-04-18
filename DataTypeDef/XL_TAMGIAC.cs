using System;

namespace DataTypeDef
{
	struct TAMGIAC
	{
		public DIEM A;
		public DIEM B;
		public DIEM C;
	}

	class XL_TAMGIAC
	{
		public static TAMGIAC NhapTamGiac()
		{
			TAMGIAC tg;
			Console.WriteLine("Nhap diem A: ");
			tg.A = XL_DIEM.NhapDiem();

			Console.WriteLine("Nhap diem B: ");
			tg.B = XL_DIEM.NhapDiem();

			Console.WriteLine("Nhap diem C: ");
			tg.C = XL_DIEM.NhapDiem();

			return tg;
		}

		public static double TinhChuViTamGiac(TAMGIAC tg)
		{
			double bc, ac, ab;
			bc = XL_DIEM.TinhKhoangCach(tg.B, tg.C);
			ac = XL_DIEM.TinhKhoangCach(tg.A, tg.C);
			ab = XL_DIEM.TinhKhoangCach(tg.A, tg.B);

			return bc + ac + ab;
		}
	}
}
