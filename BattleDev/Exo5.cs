using System;
using System.Collections.Generic;
using System.Linq;

namespace BattleDev
{
    class Exo5
    {
		static void Main(string[] args)
		{
			int nbStation;
			int.TryParse(Console.ReadLine(), out nbStation);

			List<Station> stationList = new List<Station>();

			for (int i = 0; i < nbStation; i++)
			{
				stationList.Add(new Station(Console.ReadLine().Split(' ')));
			}

			stationList.OrderBy(x => x.y);

			double dist = 0;

			Station[] tab = stationList.ToArray();

			for (int i = 0; i < tab.Length; i++)
			{
				dist += tab[i].Dist(tab[i + 1]);
			}
			dist += tab[tab.Length - 1].Dist(tab[0]);

			Console.WriteLine((int)Math.Round(dist));
		}
	}

	class Station
	{
		public int x;
		public int y;
		public int z;

		public Station(string[] coord)
		{
			int.TryParse(coord[0], out x);
			int.TryParse(coord[1], out y);
			int.TryParse(coord[2], out z);
		}

		public double Dist(Station other)
		{
			return Math.Sqrt(Math.Pow(other.x - x, 2) + Math.Pow(other.y - y, 2) + Math.Pow(other.z - z, 2));
		}
	}
}
