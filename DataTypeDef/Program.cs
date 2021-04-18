using System;

namespace DataTypeDef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DIEM a, b;
            a = XL_DIEM.NhapDiem();
            b = XL_DIEM.NhapDiem();

            double kq = XL_DIEM.TinhKhoangCach(a, b);

            string Chuoi = "Ket qua la " + kq;
            Console.WriteLine(Chuoi);

            TAMGIAC tg;

            tg = XL_TAMGIAC.NhapTamGiac();
            double kq_tg = XL_TAMGIAC.TinhChuViTamGiac(tg);

            string Chuoi_tg = "Ket qua la " + kq_tg;
            Console.WriteLine(Chuoi_tg);
        }
    }
}
