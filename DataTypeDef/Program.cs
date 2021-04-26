using System;

namespace DataTypeDef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Nhap 2 diem a, b");
            DIEM a, b;
            a = XL_DIEM.NhapDiem();
            b = XL_DIEM.NhapDiem();

            Console.WriteLine("Khoang cach 2 diem la: ");
            double kq = XL_DIEM.TinhKhoangCach(a, b);

            string Chuoi = "Ket qua la " + kq;
            Console.WriteLine(Chuoi);

            Console.WriteLine("Nhap 3 diem A, B, C cua tam giac");
            TAMGIAC tg;

            tg = XL_TAMGIAC.NhapTamGiac();
            double kq_tg = XL_TAMGIAC.TinhChuViTamGiac(tg);

            string Chuoi_tg = "Ket qua la " + kq_tg;
            Console.WriteLine(Chuoi_tg);

            Console.WriteLine("Nhap cac diem cua da giac");
            DAGIAC dg;

            dg = XL_DAGIAC.NhapDaGiac();

            Console.Write("Chu vi da giac la: ");
            double kq_dg = XL_DAGIAC.TinhChuViDaGiac(dg);

            Console.WriteLine(kq_dg);
        }
    }
}
