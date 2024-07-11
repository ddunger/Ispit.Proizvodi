using System;

namespace Ispit.Proizvodi
{
	internal class Predavac
	{
		public event Delegates.PocniPisatiIspit Ispit;
		public DateTime pocetakIspita;
		public void ZvoniZvono()
		{
			pocetakIspita = DateTime.Now;
			Console.WriteLine("Zvoni zvono i ispit pocinje\n\n");
			Ispit?.Invoke(pocetakIspita);
		}

		public void IspitZaprimljen(Polaznik polaznik)
		{
			Console.WriteLine($"Predavac je zaprimiio ispit od {polaznik.ImePrezime}.");
		}
	}
}