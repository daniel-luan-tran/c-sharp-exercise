using System;
namespace Mang2Chieu_Exercises
{
    class Bai_316
    {
        public static void KTSonguyenChanBehon2015(int[,] A)
        {
            int i, j;
            bool KT = false;
            for (i = 0; i < A.GetLength(0); i++)
            {
                for (j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 == 0 && A[i, j] < 2015)
                    {
                        KT = true;
                    }
                }
            }
            if (KT == true)
            {
                Console.WriteLine("Cac so nguyen to chan va be hon 2015: ");
                for (i = 0; i < A.GetLength(0); i++)
                {
                    for (j = 0; j < A.GetLength(1); j++)
                    {
                        if (A[i, j] % 2 == 0 && A[i, j] < 2015)
                        {
                            Console.Write($"{A[i, j]}  ");
                        }
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Khong co so nguyen to nao chan va be hon 2015");
            }
        }
    }
}