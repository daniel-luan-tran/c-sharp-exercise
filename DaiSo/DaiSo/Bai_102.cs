using System;

namespace DaiSo
{
    class Bai_102
    {
        public static void NgayKe(int Ngay, int Thang, int Nam)
        {
            Console.WriteLine($" Ngay {Ngay} / Thang {Thang} / Nam {Nam} ");
            int count = 0;

            if (Nam % 100 == 0 && Nam % 4 == 0)
            {
                if (Thang == 2)
                {
                    count = 29;
                }
                else if (Thang == 1 || Thang == 3 || Thang == 5 || Thang == 7 || Thang == 8 || Thang == 10 || Thang == 12)
                {
                    count = 31;
                }
                else
                {
                    count = 30;
                }
            }
            else
            {
                if (Thang == 2)
                {
                    count = 28;
                }
                else if (Thang == 1 || Thang == 3 || Thang == 5 || Thang == 7 ||  Thang == 8 || Thang == 10 || Thang == 12)
                {
                    count = 31;
                }
                else
                {
                    count = 30;
                }
            }

            if ( Ngay == count && Thang != 12)
            {
                Thang = Thang + 1;
                Ngay = 1;
            }
            else if (Thang == 12 && Ngay == count) //Thang 12 => Ngay = count = 31
            {
                Nam = Nam + 1;
                Ngay = 1;
                Thang = 1;
            }
            else
            {
                Ngay = Ngay + 1;
            }
            Console.WriteLine($"count = {count}");
            Console.WriteLine($"Ngay ke la Ngay { Ngay } / Thang { Thang } / Nam { Nam } ");
        }
    }
}
