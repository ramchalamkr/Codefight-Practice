using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace VerifySudoku
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			char[][] grid = new char[9] []; 
			for (int i = 0; i < 9; i++)
				for (int j = 0; j < 9; j++)
					grid[i][j] = Convert.ToChar(Console.ReadLine ());
			Console.WriteLine (sudoku2 (grid));

		}

		public static bool sudoku2(char[][] a) {
			Dictionary<char,int> dict = new Dictionary<char,int>()
			{
				{'1',1},{'2',1},{'3',1},{'4',1},{'5',1},{'6',1},{'7',1},{'8',1},{'9',1}
			};

			//check columns
			for(int i=0;i<9;i++)
			{
				dict = DictRest(dict);
				for(int j=0;j<9;j++)
				{
					if(dict.ContainsKey(a[j][i]))
					{
						if(dict[a[j][i]]>0)
							dict[a[j][i]]-=1;
						else
						{
							Console.WriteLine(dict[a[j][i]]);
							return false;
						}

					}

				}
			}

			for(int i=0;i<9;i++)
			{
				dict = DictRest(dict);
				for(int j=0;j<9;j++)
				{
					if(dict.ContainsKey(a[i][j]))
					{
						if(dict[a[i][j]]>0)
							dict[a[i][j]]-=1;
						else
						{
							Console.WriteLine(dict[a[i][j]]);
							return false;
						}

					}

				}
			}

			for(int i=0;i<9;i++)
			{
				dict = DictRest(dict);
				for(int j =0;j<9;j++)
				{
					if(dict.ContainsKey(a[3*(i/3)+j/3][3*(i%3) + j%3]))
					{
						if(dict[a[3*(i/3)+j/3][3*(i%3) + j%3]]>0)
							dict[a[3*(i/3)+j/3][3*(i%3) + j%3]]-=1;
						else
							return false;
					}
				}
			}
			return true;
		}

		public static Dictionary<char,int> DictRest(Dictionary<char,int> dict)
		{
			List<char> list = new List<char>(dict.Keys);
			foreach(var k in list)
			{
				dict[k] = 1;
			}
			return dict;
		}



	}
}
