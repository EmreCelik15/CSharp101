using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan = new Calisan()
            {
                // Name = "Emre",
                // Surname = "Çelik",
                // Salary = 5000
                Name="Emre"
            };
            calisan.CalisanBilgisi();
        }
    }
    public class Calisan
    {
        public Calisan(string name, string surName, int salary)
        {
            this.Name = name;
            this.Surname = surName;
            this.Salary = salary;
        }
        public Calisan(string name)
        {
            this.Name = name;
        }
        public Calisan() { }
        public string Name;
        public string Surname;
        public int Salary;
        public void CalisanBilgisi()
        {
            Console.WriteLine("Çalişan Adi:{0}", Name);
            Console.WriteLine("Çalişan Soyadi:{0}", Surname);
            Console.WriteLine("Çalişan Maasi:{0}", Salary);
        }
    }
}
