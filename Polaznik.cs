using System;

namespace Ispit.Proizvodi
{
	public class Polaznik
	{
		public delegate void PredajIspit(Polaznik polaznik);

		public event PredajIspit IspitZavrsen;

		public string ImePrezime { get; set; }

		public void OdgovoriNaPitanja(DateTime vrijeme_pocetka)
		{ 
			Console.WriteLine($"Polaznik {ImePrezime} je krenuo pisati ispit u {vrijeme_pocetka.ToString("HH:mm, dd.MM.yyyy")}");
		}

		public void PredajOdgovoreNaPitanja()
		{
			Console.WriteLine($"Polaznik {ImePrezime} predaje odgovore na pitanja.");
			IspitZavrsen?.Invoke(this);
		}
	}
}
