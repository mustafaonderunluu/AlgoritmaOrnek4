using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaOrnek4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Kullanıcının girdiği sayının tam bölenlerini bulan ve ekranda listeleyen
             aynı zamanda tam bölenlerin sayısını da ekranda gösteren C# Console Örneği */

            int sayı, sayac = 0;
            Console.Write("Sayı : ");
            sayı = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayı; i++)
            {
                if (sayı % i == 0)
                    Console.WriteLine(i);
                sayac++;




            }
            Console.WriteLine("Tam Bölen Sayısı : " + sayac);

            Console.ReadKey();
            /*  Derece olarak verilen sıcaklığı Fahrenayta çeviren örnek */

            double deg, fah;
            Console.Write("Derece Giriniz : ");
            deg = Convert.ToDouble(Console.ReadLine());
            fah = deg * 1.8 + 32;
            Console.Write("Giriline Derece Değeri : {0}, Fahrenait Değeri : {1} ",deg,fah);
            Console.ReadKey();




        }
    }
}
