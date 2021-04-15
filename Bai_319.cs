using System;
namespace Mang2Chieu_Exercises
{
    class Bai_319
    {
        public static void SapxepSothucTangdanTrenxuongTraisang(double[,] B)
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
            XL_MaTran.Xuatmatran_Sothuc(B);
            Console.WriteLine();
        }
    }
}