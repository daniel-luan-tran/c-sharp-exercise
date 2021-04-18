using System;

namespace Mang2Chieu_Exercises
{
	class Bai_353 //Kiem tra ma tran so thuc co giam dan
	{
		public static bool AscentCheck(double[,] arr)
		{
            int i, j;
            double x = arr[0, 0];
            for (i = 0; i < arr.GetLength(0); i++)
            {
                for (j = 0; j < arr.GetLength(1); j++)
                {
                    if (x > arr[i, j])
                    {
                        Console.WriteLine("Ma tran khong tang dan");
                        return false;
                    }
                    x = arr[i, j];
                }
            }
            Console.WriteLine("Ma tran tang dan");
            return true;
        }
    }
}
