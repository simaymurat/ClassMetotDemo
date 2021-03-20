using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
	class MusteriManager
	{
		public void Ekle( Musteri musteri )
		{
			Console.WriteLine("Müşteri eklendi:" + musteri.Ad);
		}
		public void Sil(Musteri musteri)
		{
			Console.WriteLine("Müşteri Silindi:" + musteri.Ad);
		}
		public void Liste(Musteri musteri)
		{

			Console.WriteLine("Müşteriler:" + musteri.Ad);
		}
	}
}
