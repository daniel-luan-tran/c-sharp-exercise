using System;

namespace Mang2Chieu_Exercises
{
    class Bai_366 //Tim so chan dau tien trong ma tran so thuc B
    {
        public static void FirstEven(double[,] arr)
        {
            int i, j;
            for (i = 0; i < arr.GetLength(0); i++)
            {
                for (j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j] % 2 == 0)
                    {
                        Console.WriteLine($"So chan dau tien trong ma tran so thuc: {arr[i,j]}");
                        break;
                    }
                }
                if (arr[i, j] % 2 == 0)
                {
                    break;
                }
            }
        }
    }
}