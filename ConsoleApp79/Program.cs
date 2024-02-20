using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace klavyedenikisayinintoplamininkupunu
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen 1. sayıyı giriniz");
            int sayi1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. sayıyı giriniz");
            int sayi2 = Int32.Parse(Console.ReadLine());

            int toplam = sayi1 + sayi2;
            int karesi = toplam * toplam * toplam;

            Console.WriteLine("Klavyeden girilen sayının toplamının küpünü={0}", karesi);
            Console.ReadLine();

        }
    }
}