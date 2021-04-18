using System;
namespace Mang2Chieu_Exercises
{
    class Bai_319
    {
        public static void SapxepSothucTangdanTrenxuongTraisang(double[,] B)
        {
            int i, j, k;

            for (j = 0; j < B.GetLength(1); j++)
            {
                for (i = 0; i < B.GetLength(0); i++)
                {
                    for (k = i + 1; k < B.GetLength(0); k++)
                    {
                        if (B[i, j] > B[k, j])
                        {
                            HoanVi.Hoan_Vi(B, i, j, k, j);
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
                            HoanVi.Hoan_Vi(B, i, j, i, k);
                        }
                    }
                }
            }

            Console.WriteLine($"Sap xep so thuc tang dan tu tren xuong va tu trai sang: ");
            XL_MaTran.Xuatmatran_Sothuc(B);
            Console.WriteLine();

            //int M = B.GetLength(0), N = B.GetLength(1);
            //for (i = 0; i < M*N -1; i++)
            //{
            //    for (j = i + 1; j < M*N; j++)
            //    {
            //        if (B[i / N, i % N] > B[j / N, j % N])
            //        {
            //            HoanVi.Hoan_Vi(B, i / N, i % N, j / N, j % N);
            //        }
            //    }
            //}

            //Console.WriteLine($"Sap xep so thuc tang dan tu tren xuong va tu trai sang full: ");
            //XL_MaTran.Xuatmatran_Sothuc(B);
            //Console.WriteLine();

            Console.WriteLine($"Sap xep so thuc tang dan tu tren xuong va tu trai sang full_Cach 2: ");
            XL_MaTran.Xuatmatran_Sothuc(B);
            Console.WriteLine();
        }
    }
}