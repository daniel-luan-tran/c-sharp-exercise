using System;

namespace Mang2Chieu_Exercises
{
	class Bai_364
	{
		public static void KiemTraTapCon(double[,] arrayA, double[,] arrayB, int AiLength, int AjLength, int BiLength, int BjLength)
		{
			int count = 0;
			for (int Bi = 0; Bi <= BiLength - AiLength; Bi++)
			{
				for (int Bj = 0; Bj <= BjLength - AjLength; Bj++)
				{
					bool flag = true;
					for (int Ai = 0; Ai < AiLength; Ai++)
					{
						for (int Aj = 0; Aj < AjLength; Aj++)
						{
							if (arrayA[Ai,Aj] != arrayB[Bi+Ai,Bj+Aj])
							{
								flag = false;
								break;
							}
						}
						if (flag == false)
						{
							break;
						}
					}
					if (flag == true)
					{
						count++;
					}
				}
			}
			if (count > 0)
            {
				Console.WriteLine("Ma tran A la ma tran con cua ma tran B");
			}
			else
            {
				Console.WriteLine("Ma tran A khong la ma tran con cua ma tran B");
			}
		}
	}
}