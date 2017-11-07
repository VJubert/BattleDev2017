using System;
using System.Collections.Generic;
using System.Text;

namespace BattleDev
{
    class Exo3
	{
		static void Main(string[] args)
		{
			int taille;
			int.TryParse(Console.ReadLine(), out taille);
			char[][] tab = new char[taille][];

			for (int i = 0; i < taille; i++)
			{
				tab[i] = Console.ReadLine().ToCharArray();
			}

			int nbCase = 0;

			for (int i = 0; i < taille; i++)
			{
				for (int j = 0; j < taille; j++)
				{
					if (tab[i][j] == 'X')
					{
						for (int k = i - 1; k < i + 2; k++)
						{
							for (int l = j - 1; l < j + 2; l++)
							{
								if (k >= 0 && k < taille && l >= 0 && l < taille)
								{
									if (tab[k][l] == '.')
									{
										nbCase++;
										tab[k][l] = 'c';
									}
								}
							}
						}
					}
				}
			}
			Console.WriteLine(nbCase);
		}
	}
}
