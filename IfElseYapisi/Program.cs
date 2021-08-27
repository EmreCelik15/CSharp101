using System;

namespace If_Else_Yapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            // if (time >= 6 && time <= 11)
            // {
            //     Console.WriteLine("Günaydın");
            // }
            // else if(time >11 && time <= 18)
            // {
            //     Console.WriteLine("İyi günler");
            // }
            // else if(time >18)
            // {
            //     Console.WriteLine("İyi geceler");
            // }
            string sonuc = time >= 6 && time <= 11 ? "Günaydın" : time > 11 && time <= 18 ? "İyi günler" : "İyi geceler";
            Console.WriteLine(sonuc);
        }
    }
}
