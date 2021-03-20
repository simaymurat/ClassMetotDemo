using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Musteri musteri1 = new Musteri();
			musteri1.Ad = "Sude";
			musteri1.Soyad = "Aykan";
			musteri1.Id = 10;

			Musteri musteri2 = new Musteri();
			musteri2.Ad = "Simay";
			musteri2.Soyad = "Murat";
			musteri2.Id = 12;

			Musteri musteri3 = new Musteri();
			musteri3.Ad = "Alara";
			musteri3.Soyad = "Murat";
			musteri3.Id = 14;

			Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3 } ;
			foreach (var musteri in musteriler)
			{
				Console.WriteLine(musteri.Ad);
				Console.WriteLine(musteri.Soyad);
				Console.WriteLine(musteri.Id);
				Console.WriteLine("----------");

			}
			MusteriManager musteriManager = new MusteriManager();
			musteriManager.Ekle(musteri1);

			MusteriManager musteriManager1 = new MusteriManager();
			musteriManager1.Liste(musteri1);
			musteriManager1.Liste(musteri2);
			musteriManager1.Liste(musteri3);

			MusteriManager musteriManager2 = new MusteriManager();
			musteriManager2.Sil(musteri3);
		}
	}
}
