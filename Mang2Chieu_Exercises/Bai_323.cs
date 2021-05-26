using System;

namespace Mang2Chieu_Exercises
{
    class Bai_323
    {
        public static double TinhTongDuongCot(double[,] array, int Cot_j)
        {
            double S = 0;
            int i;
            for (i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, Cot_j] > 0)
                {
                    S = S + array[i, Cot_j];
                }
            }
            return S;
        }
    }
}
