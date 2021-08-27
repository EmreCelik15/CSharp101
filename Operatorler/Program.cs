using System;

namespace Operatorler
{
    class Program
    {


        static void Main(string[] args)
        {

            int sayi1 = 25;
            int sayi2 = 35;
            int toplam = sayi1 + sayi2;

            bool isSuccess = true;

            if (toplam < 50 && sayi1 < sayi2)
            {
                Console.WriteLine("Toplam 50 den küçüktür.");
            }
            else
            {
                Console.WriteLine(isSuccess);
            }



        }
    }
}
