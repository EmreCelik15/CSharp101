using System;
using System.Collections.Generic;

namespace Odev_1
{
    class Program
    {
        //Kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
        static void Main(string[] args)
        {
            int sayi, deger;
            System.Console.WriteLine("Lütfen pozitif bir sayi giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Lütfen kaç tane pozitif sayı gireceğinizi söyleyiniz.");
            deger = int.Parse(Console.ReadLine());
            List<int> sayilar = new List<int>();
            for (int i = 1; i <= deger; i++)
            {
                System.Console.WriteLine(i + ".sayiyi giriniz...");
                sayilar.Add(int.Parse(Console.ReadLine()));

            }
            foreach (var item in sayilar)
            {
                if (item % 2 == 0)
                {
                    System.Console.WriteLine(item);
                }
            }

        }
    }
}
