using System;

namespace Mang2Chieu_Exercises
{
    class Bai_322
    {
        public static double TinhTongDong(double[,] array, int Dong_i)
        {
            double S = 0;
            int j;
            for (j = 0; j < array.GetLength(1); j++)
            {
                S = S + array[Dong_i, j];
            }
            return S;
        }
    }
}
