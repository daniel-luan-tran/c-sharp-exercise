using System;

namespace DataTypeDef
{
    public struct DIEM
    {
        public int X;
        public int Y;
    }

    class XL_DIEM
    {
        public static DIEM NhapDiem()
        {
            DIEM diem;
            Console.WriteLine("Nhap X: ");
            diem.X = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap Y: ");
            diem.Y = int.Parse(Console.ReadLine());

            return diem;
        }

        public static double TinhKhoangCach(DIEM diem1, DIEM diem2)
        {
            return Math.Sqrt(((diem1.X - diem2.X) * diem1.X - diem2.X))
                + ((diem1.Y - diem2.Y) * (diem1.Y - diem2.Y));
        }
    }
}
{
    public Class1()
	{
	}
}
