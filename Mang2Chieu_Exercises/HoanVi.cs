using System;

namespace Mang2Chieu_Exercises
{
	public class HoanVi
	{
		public static void Hoan_Vi(double[,]B, int col1, int row1, int col2, int row2)
		{
			double temp = B[col1, row1];
			B[col1, row1] = B[col2, row2];
			B[col2, row2] = temp;
		}
	}
}
