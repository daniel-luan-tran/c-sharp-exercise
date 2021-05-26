using System;

namespace Mang2Chieu_Exercises
{
    class Bai_329
    {
        public static void TriTuyetDoi(double[,] array)
        {
            int i,j;
            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    if(array[i,j] < 0)
                    {
                        array[i,j] = Math.Abs(array[i,j]);
                        //array[i, j] = array[i, j] * (-1);
                    }
                }
            }
        }
    }
}