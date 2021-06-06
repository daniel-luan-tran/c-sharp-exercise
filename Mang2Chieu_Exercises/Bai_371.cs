using System;

namespace Mang2Chieu_Exercises
{
	class Bai_371
	{
		//Find Max in matrix
		public static double MaxFilter(double[,] array)
		{
			double Max = array[0,0];
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{	
					if ( array[i,j] > Max )
                    {
						Max = array[i, j];
					}
				}
			}
			return Max;
		}

		//Kiem tra co gia tri Max tren tung dong
		public static bool Check(double[,] array, int rowIndex)
		{
			bool boolean = false;
			double Max = MaxFilter(array);
			for (int j = 0; j < array.GetLength(1); j++)
			{
				if (array[rowIndex, j] == Max)
				{
					boolean = true;
				}
			}
			return boolean;
		}

		//Liet ke dong co gia tri Max
		public static void RowMaxValueFilter(double[,] array)
		{
			for(int rowIndex = 0; rowIndex < array.GetLength(0); rowIndex++)
			{
				if ( Check(array, rowIndex) == true )
				{
					Console.WriteLine($"Dong thu {rowIndex+1} co chua gia tri Max");
				}
			}
		}
	}
}