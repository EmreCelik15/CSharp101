using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        //Kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        static void Main(string[] args)
        {

            int deger;
            System.Console.WriteLine("Lütfen kaç adet kelime gireceğinizi yazınız");
            deger = int.Parse(Console.ReadLine());
            List<string> kelimeler = new List<string>();
            for (int i = 1; i <= deger; i++)
            {
                System.Console.WriteLine(i + ". kelime");
                kelimeler.Add(Console.ReadLine());
            }
            foreach (var item in kelimeler)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
