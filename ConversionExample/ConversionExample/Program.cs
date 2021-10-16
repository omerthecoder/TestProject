using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekrandan kullanıcıdan sayı alıp bu sayının karesini hesaplayan programı yazınız.
            Console.WriteLine("sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = sayi * sayi;
            Console.WriteLine($"{sonuc}");
            
            Console.ReadLine();

        }
    }
}
