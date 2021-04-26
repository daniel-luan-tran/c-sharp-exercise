using System;

namespace DataTypeDef
{
	struct DAGIAC
	{
		public DIEM[] dsDIEM;
	}

	class XL_DAGIAC
	{
		public static DAGIAC NhapDaGiac()
		{
			DAGIAC dg;

			Console.WriteLine("Nhap so diem: ");
			int N = int.Parse(Console.ReadLine());

			dg.dsDIEM = new DIEM[N];

			for (int i = 0; i < N; i++)
            {
				Console.WriteLine($"Nhap dinh thu {i+1}: ");
				dg.dsDIEM[i] = XL_DIEM.NhapDiem();
            }

			return dg;
		}

		public static double TinhChuViDaGiac(DAGIAC dg)
		{
			double ChuVi = 0;
			int N = dg.dsDIEM.Length;
			for (int i = 0; i < N - 1; i++)
            {
				ChuVi = ChuVi + XL_DIEM.TinhKhoangCach(dg.dsDIEM[i], 
					dg.dsDIEM[i + 1]);
            }

			ChuVi = ChuVi + XL_DIEM.TinhKhoangCach(dg.dsDIEM[0],
				dg.dsDIEM[N - 1]);
			return ChuVi;
		}
	}
}
