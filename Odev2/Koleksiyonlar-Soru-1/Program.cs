using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru-1

            // List<int> sayilar = new List<int>();
            // List<int> asalSayilar = new List<int>();
            // List<int> asalOlmayanlar = new List<int>();
            // int toplam1=0;
            // int toplam2=0;
            // for (int i = 1; i <= 20; i++)
            // {
            //     System.Console.WriteLine("Lütfen 20 tane pozitif sayı giriniz.");
            //     System.Console.WriteLine(i + ". sayi");
            //     int sayi = Convert.ToInt32(Console.ReadLine());
            //     sayilar.Add(sayi);


            // }

            // foreach (var item in sayilar)
            // {
            //     for (int j = 2; j < item; j++)
            //     {
            //         if (item % j == 0)
            //         {
            //             asalOlmayanlar.Add(item);
            //             break;
            //         }
            //         else
            //         {
            //             asalSayilar.Add(item);
            //             break;
            //         }
            //     }
            // }

            // asalOlmayanlar.Reverse();
            // asalSayilar.Reverse();
            // System.Console.WriteLine("Asal Olmayan Sayılar");
            // foreach (var item in asalOlmayanlar)
            // {

            //     System.Console.Write(item + " ");
            //     System.Console.WriteLine();
            // }
            // System.Console.WriteLine("Asal Olan Sayılar");
            // foreach (var asallar in asalSayilar)
            // {

            //     System.Console.Write(asallar + " ");
            //     System.Console.WriteLine();
            // }
            // System.Console.WriteLine("***************Eleman Sayıları************");
            // System.Console.WriteLine("Asal olmayan dizinin eleman sayısı= " + asalOlmayanlar.Count);
            // System.Console.WriteLine("Asal olan dizinin eleman sayısı= " + asalSayilar.Count);
            // System.Console.WriteLine("*********Ortalamalar*********");
            // System.Console.WriteLine("***********Asal Sayılar Ortalaması**********");
            // foreach (var item in asalSayilar)
            // {
            //     toplam1  += item;
            // }
            // System.Console.WriteLine(toplam1/asalSayilar.Count);
            // System.Console.WriteLine("***********Asal Olmayan Sayılar Ortalaması**********");
            // foreach (var item in asalOlmayanlar)
            // {
            //     toplam2 +=item;
            // }
            // System.Console.WriteLine(toplam2/asalOlmayanlar.Count);

            //Soru-2
            
            List<char> sesliler = new List<char>();
            System.Console.WriteLine("Lütfen bir cümle yazınız.");
            string metin = Console.ReadLine();

            string sesli = "aeıioöuü";
            for (int i = 0; i < metin.Length; i++)
            {

                if (sesli.Contains(metin[i]))
                {
                    sesliler.Add(metin[i]);
                }
            }
            foreach (var item in sesliler)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}

