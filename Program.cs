using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birimdönüştürücü
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Birin dönüştürme projesine hoşgeldiniz.");
			while (true) 
			{
				Console.WriteLine("\n Dönüştürmek istediğiniz birimi seçiniz.");
				Console.WriteLine("1 - Kilomtre ---> Metre");
				Console.WriteLine("2 - Metre ---> Kilometre");
				Console.WriteLine("3 - Celcius ---> Fahreneit");
				Console.WriteLine("4 - Fahreneit ---> Celcius");
				Console.WriteLine("0 - çıkış");

				int sec = Convert.ToInt32(Console.ReadLine());
				if(sec != null)
				{
					switch (sec)
					{
						case 1:
							Kilometretometre();
							break;
						case 2:
							Metretokilometre();
							break;
						case 3:
							Celciustofahreneit();
							break;
						case 4:
							Fahreneittocelcius();
							break;
						case 0:
							Console.WriteLine("Programndan çıkılıyor");
							return;
						default:
							Console.WriteLine("Gerçesiz seçim yaptınıız");
							break;
					}
				}
				
			}
		}
		static void Kilometretometre()
		{
			Console.WriteLine("Kilometre cinsinden uzunluu giriniz:");
			double km = Convert.ToDouble(Console.ReadLine());
			double m = km * 1000;
			Console.WriteLine($"{km} kilometre, {m} metre eder.");
		}
		static void Metretokilometre()
		{
			Console.WriteLine("Metre cisinden uzunluğu gir.");
			double met = Convert.ToDouble(Console.ReadLine());
			double m = met / 1000;
			Console.WriteLine($"{met} metre, {m} kilometre eder.");
		}
		static void Celciustofahreneit()
		{
			Console.WriteLine("Celcius türünden derece girini:");
			double celcius = Convert.ToDouble(Console.ReadLine());
			double fahreneit = (celcius * 9 / 5) + 32;
			Console.WriteLine($"{celcius} celcius, {fahreneit} derece eder.");
		}
		static void Fahreneittocelcius()
		{
			Console.WriteLine("Fahreneit türünden derece giriniz.");
			double fahreneit = Convert.ToDouble(Console.ReadLine());
			double celcius = (fahreneit - 32) * 5 / 9;
			Console.WriteLine($"{fahreneit} fahreneit, {celcius} celcius derece eder.");
		}
	}
}
