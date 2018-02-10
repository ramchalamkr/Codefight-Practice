using System;

namespace FirstDuplicate
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Write Main Function Accordingly. This is just a sample
			int[] arr = new int[5]{ 1, 2, 3, 4, 2 };
			Console.WriteLine (firstDuplicate (arr));
		}
		// Function returns in O(n) in only 1 iteration.
		public static int firstDuplicate(int[] a) {
			int n = a.Length;
			if(n==1)
				return -1;
			for(int i=0;i<n;i++)
			{
				if(a[Math.Abs(a[i])-1] <0)
					return Math.Abs(a[i]);
				else
					a[Math.Abs(a[i])-1] = -a[Math.Abs(a[i])-1];
			}

			return -1;
		}
	}
}
