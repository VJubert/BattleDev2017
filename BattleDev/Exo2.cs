using System;
using System.Collections.Generic;
using System.Text;

namespace BattleDev
{
    class Exo2
	{
		static void Main(string[] args)
		{
			int nbProduits;
			int.TryParse(Console.ReadLine(), out nbProduits);
			string produit = Console.ReadLine();

			int min = int.MaxValue;
			int prix;
			for (int i = 0; i < nbProduits; i++)
			{
				string[] x = Console.ReadLine().Split(' ');
				if (x[0] == produit)
				{
					int.TryParse(x[1], out prix);
					if (prix < min)
					{
						min = prix;
					}
				}
			}
			Console.WriteLine(min);
		}
	}
}
