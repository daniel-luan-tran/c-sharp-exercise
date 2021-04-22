using System;

namespace Mang2Chieu_Exercises
{
    class Bai_381 //Tim gia tri xuat hien nhieu nhat
    {
        public static int Count(double[,] arr, double x)
        {
            //Dem so luong gia tri xuat hien
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (x == arr[i, j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public static void MostAppearValue(double[,] arr)
        {
            int i, j;
            int MaxCount = 1;
            double MaxValue = arr[0, 0];
            for (i = 0; i < arr.GetLength(0); i++)
            {
                for (j = 0; j < arr.GetLength(1); j++)
                {
                    int count = Count(arr, arr[i, j]);
                    if (count >= MaxCount)
                    {
                        MaxCount = count;
                        MaxValue = arr[i, j];
                    }
                }
            }
            Console.WriteLine($"Gia tri xuat hien nhieu nhat la {MaxValue}, xuat hien {MaxCount} lan");
        }
    }
}
