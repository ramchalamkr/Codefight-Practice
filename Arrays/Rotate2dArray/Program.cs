using System;

namespace Rotate2dArray
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[,] m = new int[,]{ { 1, 2 }, { 3, 4 } };
			int[,] res = rotateImage(m);
			for (int i = 0; i < res.GetLength (0); i++) {
				for (int j = 0; j < res.GetLength (1); j++)
					Console.Write (res [i, j]);
				Console.WriteLine ();
			}
		}
		//Using only O(1) extra memory
		public static int[,] rotateImage(int[,] matrix) {
			int n = matrix.GetLength(0);
			for(int i=0;i<n/2;i++)
			{
				for(int j=i;j<n-i-1;j++)
				{
					int temp = matrix[i,j];
					matrix[i,j] = matrix[n-j-1,i];
					matrix[n-j-1,i] = matrix[n-i-1,n-j-1];
					matrix[n-i-1,n-j-1] = matrix[j,n-i-1];
					matrix[j,n-i-1] = temp;

				}
			}
			return matrix;
		}


	}
}
