using System;

namespace Mang2Chieu_Exercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            /////////////////////////////
            //Nhap ma tran so nguyen A
            int[,] A;
            A = XL_MaTran.Nhapmatran_Songuyen();

            //Xuat ma tran so nguyen
            XL_MaTran.Xuatmatran_Songuyen(A);
            /////////////////////////////


            ////Bai 316: Kiem tra so nguyen chan be hon 2015
            //Bai_316.KTSonguyenChanBehon2015(A);

            ////Bai 335: Dem so luong so nguyen to trong ma tran so nguyen
            //Bai_335.PrimeCount(A);

            ////Bai 337: Dem so chu so trong ma tran nguyen duong
            //uint[,] A_duong = XL_MaTran.Nhapmatran_Songuyen_Duong();
            //Bai_337.NumberCount(A_duong);

            /////////////////////////////////
            ////Nhap ma tran so thuc
            //double[,] A;
            //A = XL_MaTran.Nhapmatran_Sothuc();

            ////Xuat ma tran so thuc
            //XL_MaTran.Xuatmatran_Sothuc(A);
            /////////////////////////////////

            /////////////////////////////////
            ////Nhap ma tran so thuc
            //double[,] B;
            //B = XL_MaTran.Nhapmatran_Sothuc();

            ////Xuat ma tran so thuc
            //XL_MaTran.Xuatmatran_Sothuc(B);
            /////////////////////////////////


            ////Bai 315: Tim Max cua ma tran so thuc B
            //Bai_315.TimMax(B);

            ////Bai 318: Tong gia tri am cua ma tran so thuc
            //Bai_318.TongSothucAm(B);

            ////Bai 319: Sap xep so thuc tang dan tu tren xuong va tu trai sang
            //Bai_319.SapxepSothucTangdanTrenxuongTraisang(B);

            ////Bai_353: Kiem tra ma tran so thuc co tang dan
            //Bai_353.AscentCheck(B);

            ////Bai 334: Dem so luong so thuc duong trong ma tran
            //Bai_334.PositiveCount(B);

            ////Bai 336: Tan suat xuat hien cua so thuc x trong ma tran so thuc
            //Bai_336.x_Count(B);

            //Bai 381: Tim gia tri xuat hien nhieu nhat trong ma tran so thuc B
            //Bai_381.MostAppearValue(B);

            //Bai 322: Tinh tong dong
            //Bai_322.TinhTongDong(B, 1);
            //Console.WriteLine(Bai_322.TinhTongDong(B, 1));

            ////Bai 323: Tinh tong cac gia tri duong tren cot
            //Console.WriteLine(Bai_323.TinhTongDuongCot(B, 1));

            ////Bai 329: Tri tuyet cac gia tri am trong ma tran
            //Bai_329.TriTuyetDoi(B);
            //XL_MaTran.Xuatmatran_Sothuc(B);

            ////Bai 368: Tim gia tri lon thu hai
            //Bai_368.SecondMaxFilter(B);

            ////Bai 364: Kiem tra ma tran A co la ma tran con cua ma tran B
            //Bai_364.KiemTraTapCon(A, B, A.GetLength(0), A.GetLength(1), B.GetLength(0), B.GetLength(1));

            //Bai 358: Liet ke cac dong co so chan
            Bai_358.RowEvenCheck(A);

            //Bai 360: Liet ke cot co so chinh phuong
            Bai_360.ColumnSquareNoCheck(A);
        }
    }
}
