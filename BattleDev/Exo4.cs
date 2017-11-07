using System;
using System.Collections.Generic;
using System.Linq;

namespace BattleDev
{
    class Exo4
	{
		private static bool TestSolution(string a, string b)
		{
			char[] chara = a.ToCharArray();
			char[] charb = b.ToCharArray();

			if (chara.Length != charb.Length)
			{
				return false;
			}

			for (int i = 0; i < chara.Length; i++)
			{
				switch (chara[i])
				{
					case 'A': if (charb[i] != 'T') return false; else break;
					case 'T': if (charb[i] != 'A') return false; else break;
					case 'C': if (charb[i] != 'G') return false; else break;
					case 'G': if (charb[i] != 'C') return false; else break;
				}
			}
			return true;
		}

		private static bool RecMain(string a, string b, string[] frags, int n, int[] choice)
		{
			if (n == frags.Length)
			{
				if (TestSolution(a, b))
				{
					List<string> resa = new List<string>();
					List<string> resb = new List<string>();
					for (int i = 0; i < n; i++)
					{
						if (choice[i] == 1)
						{
							resa.Add(frags[i]);
						}
						else if (choice[i] == 2)
						{
							resb.Add(frags[i]);
						}
					}

					Console.WriteLine(string.Join(" ", resa) + "#" + string.Join(" ", resb));

					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				choice[n] = 1;
				if (!RecMain(a + frags[n], b, frags, n + 1, choice))
				{
					choice[n] = 2;
					if (!RecMain(a, b + frags[n], frags, n + 1, choice))
					{
						return false;
					}
					else
					{
						return true;
					}
				}
				else
				{
					return true;
				}
			}
		}

		static void Main(string[] args)
		{
			int nbFrag;
			int.TryParse(Console.ReadLine(), out nbFrag);

			List<string> frags = new List<string>();

			for (int i = 0; i < nbFrag; i++)
			{
				frags.Add(Console.ReadLine());
			}

			while (!RecMain(string.Empty, string.Empty, frags.ToArray(), 0, new int[frags.Count]))
			{
				frags = frags.OrderBy(_ => Guid.NewGuid()).ToList();
			}
		}
	}
}
