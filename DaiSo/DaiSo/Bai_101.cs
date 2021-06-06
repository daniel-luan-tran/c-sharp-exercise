using System;

namespace DaiSo
{
	class Bai_101
    {
        public static int DayofMonthCount(int Thang, int Nam)
        {
            int count = 0;
            if ( Nam % 100 == 0 && Nam % 4 ==0 )
            {
                if ( Thang == 2 )
                {
                    count = 29;
                }
                else if ( Thang == 1 || Thang == 3 || Thang == 5 || Thang == 7 || Thang == 8 || Thang == 10 || Thang == 12)
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
                else if (Thang == 1 || Thang == 3 || Thang == 5 || Thang ==7 || Thang == 8 || Thang == 10 || Thang == 12)
                {
                    count = 31;
                }
                else
                {
                    count = 30;
                }
            }
            return count;
        }
    }
}

