using System;

namespace DaiSo
{
    class Bai_103
    {
        public static void NgayPhiaTruoc(int Ngay, int Thang, int Nam)
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
                else if (Thang == 1 || Thang == 3 || Thang == 5 || Thang == 7 || Thang == 8 || Thang == 10 || Thang == 12)
                {
                    count = 31;
                }
                else
                {
                    count = 30;
                }
            }

            if (Ngay == 1 && Thang == 1)
            {
                Nam = Nam - 1;
                Thang = 12;
                Ngay = Bai_101.DayofMonthCount(Thang, Nam); // 1 / 1 / 2000 => 31 / 12 / 1999 => Ngay = count cua thang truoc
            }
            else if (Thang != 1 && Ngay == 1) // 1 / 3 / 2000 => 29 / 2 /2000 => Ngay = count cua thang truoc
            {
                Thang = Thang - 1;
                Ngay = Bai_101.DayofMonthCount(Thang,Nam);
            }
            else
            {
                Ngay = Ngay - 1 ;
            }
            Console.WriteLine($"Ngay truoc la Ngay { Ngay } / Thang { Thang } / Nam { Nam } ");
        }
    }
}
