using System;

namespace Ispit.Proizvodi
{
	internal class Predavac
	{
		public event Delegates.PocniPisatiIspit Ispit;

		public void ZvoniZvono()
		{
			Console.WriteLine("Zvoni zvono i ispit pocinje\n\n");
			Ispit?.Invoke(DateTime.Now);
		}

		public void IspitZaprimljen(Polaznik polaznik)
		{
			Console.WriteLine($"Predavac je zaprimiio ispit od {polaznik.ImePrezime}.");
		}
	}
}