using System;

namespace Mang2Chieu_Exercises
{
    class XL_MaTran
    {
        public static int[,] Nhapmatran_Songuyen()
        {
            //Nhap ma tra so nguyen A
            Console.Write("Nhap so dong cua ma tran so nguyen A: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Nhap so cot cua ma tran so nguyen A: ");
            int M = int.Parse(Console.ReadLine());

            int[, ] A = new int[N, M];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.WriteLine($"Nhap A[{i},{j}]");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return A;
        }
        public static void Xuatmatran_Songuyen(int[,] A)
        {
            Console.WriteLine();
            //Xuat ma tran so nguyen A
            Console.WriteLine($"Xuat ma tran so nguyen");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write($"{A[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static int TinhTong(int[,] A)
        {
            //Tinh tong cac phan tu tren ma tran so nguyen
            Console.WriteLine($"Tinh tong cac phan tu");
            int S = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    S = S + A[i, j];
                }
            }
            Console.WriteLine($"Tong la: {S}");
            return S;
        }

        public static double[,] Nhapmatran_Sothuc()
        {
            //Nhap ma tra so thuc
            Console.Write("Nhap so dong cua ma tran so thuc B: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Nhap so cot cua ma tran so thuc B: ");
            int M = int.Parse(Console.ReadLine());

            double[,] A = new double[N, M];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.WriteLine($"Nhap B[{i},{j}]");
                    A[i, j] = double.Parse(Console.ReadLine());
                }
            }
            return A;
        }
        public static void Xuatmatran_Sothuc(double[,] B)
        {
            //Xuat ma tran so thuc
            Console.WriteLine($"Xuat ma tran so thuc B");
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        Console.Write($"{B[i, j]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        public static double Bai315_TimMax(double[,] B)
        {
            //Tim max cua ma tran so thuc
            Console.WriteLine("Bai 315_Tim max cua ma tran so thuc");
            double Max = 0;
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i,j] > Max)
                    {
                        Max = B[i, j];
                    }
                }
            }
            Console.WriteLine($"Gia tri lon nhat la: {Max}");
            return Max;
        }

        public static bool Bai316_KTSonguyenChanBehon2015 (int[,] A)
        {
            int i, j;
            bool KT = false;
            for (i = 0; i < A.GetLength(0); i++)
            {
                for (j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i,j] % 2 == 0 && A[i,j] < 2015)
                    {
                        KT = true;     
                    }
                }
            }
            Console.WriteLine(KT);
            return KT;
        }
        public static double Bai318_TongSothucAm(double[,] B)
        {
            int i, j;
            double S = 0;
            for (i = 0; i < B.GetLength(0); i++)
            {
                for (j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j] < 0)
                    {
                        S = S + B[i, j];
                    }
                }
            }
            Console.WriteLine($"Tong gia tri am trong ma tran so thuc: {S}");
            return S;
        }

        public static void Bai319_SapxepSothucTangdanTrenxuongTraisang(double[,] B)
        {
            int i, j, k;
            double tmp;

            for (j = 0; j < B.GetLength(1); j++)
            {
                for (i = 0; i < B.GetLength(0); i++)
                {
                    for (k = i + 1; k < B.GetLength(0); k++)
                    {
                        if (B[i, j] > B[k, j])
                        {
                            tmp = B[i, j];
                            B[i, j] = B[k, j];
                            B[k, j] = tmp;
                        }
                    }
                }
            }

            for (i = 0; i < B.GetLength(0); i++)
            {
                for (j = 0; j < B.GetLength(1); j++)
                {
                    for (k = j + 1; k < B.GetLength(1); k++)
                    {
                        if (B[i, j] > B[i, k])
                        {
                            tmp = B[i, j];
                            B[i, j] = B[i, k];
                            B[i, k] = tmp;
                        }
                    }
                }
            }

            Console.WriteLine($"Sap xep so thuc tang dan tu tren xuong va tu trai sang: ");
            Xuatmatran_Sothuc(B);
            Console.WriteLine();
        }
    }
}
