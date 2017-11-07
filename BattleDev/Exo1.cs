using System;
using System.Collections.Generic;
using System.Text;

namespace BattleDev
{
    class Exo1
	{
		static void Main(string[] args)
		{
			int.TryParse(Console.ReadLine(), out var tours);
			int a = 0;
			int b = 0;
			for (int i = 0; i < tours; i++)
			{
				var carte = Console.ReadLine().Split(" ");
				int.TryParse(carte[0], out var ca);
				int.TryParse(carte[1], out var cb);
				if (ca > cb)
				{
					a++;
				}
				else if (ca < cb)
				{
					b++;
				}
			}

			Console.WriteLine(a > b ? "A" : "B");
		}
	}
}
