using System;

namespace Mang2Chieu_Exercises
{
    class Bai_388
    {
        //Xac dinh so nguyen to
        public static bool SoNguyenTo(int value)
        {
            bool check = true;

            if (value <= 1)
            {
                check = false;
            }

            for (int k = 2; k < value; k++)
            {
                if (value % k == 0)
                {
                    check = false;
                }
            }
            return check;
        }

        //Dem so nguyen to tren moi dong
        public static int DemSoNguyenToDong_i(int[,] array, int Dong_i)
        {
            int Dem = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (SoNguyenTo(array[Dong_i, j]) == true)
                {
                    Dem++;
                }
            }
            return Dem;
        }        

        public static void DongCoNhieuSoNguyenToNhat(int[,] array)
        {
            int Max = DemSoNguyenToDong_i(array, 0);

            //Tim so luong so nguyen to nhieu nhat
            for (int Dong_i = 0; Dong_i < array.GetLength(0); Dong_i++)
            {
                if(DemSoNguyenToDong_i(array, Dong_i) > Max)
                {
                    Max = DemSoNguyenToDong_i(array, Dong_i);
                }
            }

            //Dong co nhieu so nguyen to nhat
            for(int Dong_i = 0; Dong_i < array.GetLength(0); Dong_i++)
            {
                if (DemSoNguyenToDong_i(array, Dong_i) == Max)
                {
                    Console.WriteLine($"Dong thu {Dong_i + 1} co {Max} so nguyen to va co nhieu so nguyen to nhat");
                }
                if (DemSoNguyenToDong_i(array, Dong_i) == 0)
                {
                    Console.WriteLine($"Dong thu {Dong_i + 1} khong co so nguyen to");
                }
            }
        }    
    }
}
