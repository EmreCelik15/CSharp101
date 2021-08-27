using System;

namespace Hata_Yönetimi
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //int a=int.Parse(null);
                Console.WriteLine("Bir sayi giriniz");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a);
            }
            // catch (ArgumentNullException ex)
            // {
            // //   Console.WriteLine("Geçersiz sayı girdiniz.");
            // //   Console.WriteLine(ex);

            // }
            catch (Exception ex)
            {

                Console.WriteLine("Girdiğiniz sayi geçersizdir");
                Console.WriteLine(ex);

            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı");
            }
        }
    }
}
