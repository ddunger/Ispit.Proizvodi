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


			foreach (var polaznik in polaznici)
			{
				polaznik.IspitZavrsen += predavac.IspitZaprimljen;
			}
			foreach (var polaznik in polaznici)
			{
				predavac.Ispit += (startTime) =>
				{
					polaznik.OdgovoriNaPitanja(DateTime.Now);
				};
			}
			predavac.ZvoniZvono();


			polaznici[2].PredajOdgovoreNaPitanja();

			Console.ReadLine();
		}
	}
}
