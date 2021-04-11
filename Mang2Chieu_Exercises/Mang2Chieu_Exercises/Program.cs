using System;

namespace Mang2Chieu_Exercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Tinh tong cac phan tu tren ma tran
            int[,] A;
            A = XL_MaTran.Nhapmatran_Songuyen();
            //int S = XL_MaTran.TinhTong(A);

            //Xuat ma tran so nguyen
            XL_MaTran.Xuatmatran_Songuyen(A);

            //Nhap ma tran so thuc
            double[,] B;
            B = XL_MaTran.Nhapmatran_Sothuc();

            //Xuat ma tran so thuc
            XL_MaTran.Xuatmatran_Sothuc(B);

            //Bai 315: Tim Max cua ma tran so thuc B
            XL_MaTran.Bai315_TimMax(B);
        }
    }
}
