using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace FirstNonRepeatingCharacter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Write Main functions appropritately as required.
			Console.WriteLine (firstNotRepeatingCharacter("aabccddef"));
		}

		//O(n) 
		public static char firstNotRepeatingCharacter(string s) {
			Hashtable ht = new Hashtable();
			int n= s.Length;
			for(int i=0;i<n;i++)
			{
				if(!ht.Contains(s[i]))
					ht.Add(s[i],0);
				else
					ht[s[i]] = Convert.ToInt32(ht[s[i]]) + 1;
			}

			for(int i=0;i<n;i++)
			{
				if(Convert.ToInt32(ht[s[i]])==0)
					return s[i];
			}
			return '_';
		}

	}
}
