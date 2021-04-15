using System;
namespace Mang2Chieu_Exercises
{
    class Bai_315
    {
        public static double TimMax(double[,] B)
        {
            //Tim max cua ma tran so thuc
            Console.WriteLine("Bai 315_Tim max cua ma tran so thuc");
            double Max = 0;
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j] > Max)
                    {
                        Max = B[i, j];
                    }
                }
            }
            Console.WriteLine($"Gia tri lon nhat la: {Max}");
            return Max;
        }
    }
}