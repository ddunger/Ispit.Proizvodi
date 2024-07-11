using System;
using System.Collections.Generic;

namespace Ispit.Proizvodi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Predavac predavac = new Predavac();

			List<Polaznik> polaznici = new List<Polaznik>
			{
				new Polaznik { ImePrezime = "Pero Peric" },
				new Polaznik { ImePrezime = "Mario Maric" },
				new Polaznik { ImePrezime = "Iva Ivic" },
				new Polaznik { ImePrezime = "Filip Filipovic" }
			};

			predavac.ZvoniZvono();

			foreach (var polaznik in polaznici)
			{
				polaznik.IspitZavrsen += predavac.IspitZaprimljen;
			}

			int delay = 5;
			foreach (var polaznik in polaznici)
			{
				polaznik.OdgovoriNaPitanja(DateTime.Now.AddMinutes(delay));
				delay += 2;
				Console.WriteLine("-----------------------------------------\n");
			}
			polaznici[2].PredajOdgovoreNaPitanja();

			Console.ReadLine();
		}
	}
}
