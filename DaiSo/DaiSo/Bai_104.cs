using System;

namespace DaiSo
{
    class Bai_104
    {
        public static int NgayThuMayTrongNam(int Ngay, int Thang, int Nam)
        {
            int TotalCount = 0;

            for (int i = 1; i < Thang; i++)
            {
                int count = Bai_101.DayofMonthCount(i, Nam);
                TotalCount = TotalCount + count;
            }

            TotalCount = TotalCount + Ngay;

            Console.WriteLine($"Ngay thu {TotalCount} trong nam");
            return TotalCount;
        }
    }
}
