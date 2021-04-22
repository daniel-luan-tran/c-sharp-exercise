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

            int[, ] arr = new int[N, M];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.WriteLine($"Nhap A[{i},{j}]");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return arr;
        }

        public static uint[,] Nhapmatran_Songuyen_Duong()
        {
            //Nhap ma tra so nguyen duong A_duong
            Console.Write("Nhap so dong cua ma tran so nguyen A duong: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Nhap so cot cua ma tran so nguyen A duong: ");
            int M = int.Parse(Console.ReadLine());

            uint[,] arr = new uint[N, M];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.WriteLine($"Nhap A[{i},{j}]");
                    arr[i, j] = uint.Parse(Console.ReadLine());
                }
            }
            return arr;
        }


        public static void Xuatmatran_Songuyen(int[,] arr)
        {
            Console.WriteLine();
            //Xuat ma tran so nguyen A
            Console.WriteLine($"Xuat ma tran so nguyen");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
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
        public static void Xuatmatran_Sothuc(double[,] arr)
        {
            //Xuat ma tran so thuc
            Console.WriteLine($"Xuat ma tran so thuc B");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static int Count(double[,] arr, double x)
        {
            //Dem so luong gia tri xuat hien
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (x == arr[i,j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Gia tri {x} xuat hien {count} lan");
            return count;
        }
    }
}
