using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        //Kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
        static void Main(string[] args)
        {
            int m, n, deger;
            System.Console.WriteLine("Lütfen bir pozitif sayi giriniz");
            m = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Lütfen bir pozitif sayi giriniz");
            n = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Lütfen kaç adet pozitif sayi gireceğinizi yazınız");
            deger = int.Parse(Console.ReadLine());
            List<int> sayilar = new List<int>();
            for (int i = 1; i <= deger; i++)
            {
                System.Console.WriteLine(i + ".sayi");
                sayilar.Add(int.Parse(Console.ReadLine()));
            }
            foreach (var item in sayilar)
            {
                if (item == m || item % m == 0)
                {
                    System.Console.WriteLine(item);
                }
            }
        }
    }
}
