using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LlogaritPagen
{

    class Employee
    {
        public int Id;
        public string Emri;
        public string Pozita;

        public Employee(int id, string emri, string pozita)
        {
            this.Id = id;
            this.Emri = emri;
            this.Pozita = pozita;

        }


    }

    class Zhvillues : Employee
    {
        public double Rroga;
        public Zhvillues(int id, string emri, string pozita, double rroga) : base(id, emri, pozita)
        {
            this.Rroga = rroga;
        }
        public void CalculateBonus(double rroga)
        {
            double bonusi = rroga * 25 / 100;

            if (bonusi > 50000)
            {
                Console.WriteLine("Ju keni fituar nje bonus, e cila eshte sa 25% e rroges tuaj (" + bonusi + "$).");
            }
            else
            {
                Console.WriteLine("Ju keni marre si bonus 50000$.");
            }
        }

    }

    class Menaxher : Employee
    {
        public double Rroga;
        public Menaxher(int id, string emri, string pozita, double rroga) : base(id, emri, pozita)
        {
            this.Rroga = rroga;
        }
        public void CalculateBonus(double rroga)
        {
            double bonusi = rroga * 25/100;

            if (bonusi > 50000)
            {
                Console.WriteLine("Ju keni fituar nje bonus, e cila eshte sa 25% e rroges tuaj (" +bonusi+"$).");
            }
            else
            {
                Console.WriteLine("Ju keni marre si bonus 50000%");
            }
        }
    }

    class Admin : Employee
    {
        public double Rroga;
        public Admin(int id, string emri, string pozita, double rroga) : base(id, emri, pozita)
        {
            this.Rroga = rroga;
        }
        public void CalculateBonus()
        {
            Console.WriteLine("Ju keni marre si bonus 50000$.");
        }
    }

        internal class Program
        {
            static void Main(string[] args)
            {
            Zhvillues zhvilluesi = new Zhvillues(12345678, "Arianit", "Zhvillues", 80000.90);
            Menaxher menaxheri = new Menaxher(87654321, "Luan", "Menaxher", 15000000.80);
            Admin admini = new Admin(246810, "Jehona", "Admin", 650000.70);

            Console.WriteLine("Id-ja: " + zhvilluesi.Id);
            Console.WriteLine("Emri: " + zhvilluesi.Emri);
            Console.WriteLine("Pozita: " + zhvilluesi.Pozita);
            Console.WriteLine("Rroga: "+ zhvilluesi.Rroga + "$");
            zhvilluesi.CalculateBonus(zhvilluesi.Rroga);

            Console.WriteLine("\n------------------------------------------------------------------------------------------\n");

            Console.WriteLine("Id-ja: " + menaxheri.Id);
            Console.WriteLine("Emri: " + menaxheri.Emri);
            Console.WriteLine("Pozita: " + menaxheri.Pozita);
            Console.WriteLine("Rroga: " + menaxheri.Rroga + "$");
            menaxheri.CalculateBonus(menaxheri.Rroga);

            Console.WriteLine("\n------------------------------------------------------------------------------------------\n");

            Console.WriteLine("Id-ja: " + admini.Id);
            Console.WriteLine("Emri: " + admini.Emri);
            Console.WriteLine("Pozita: " + admini.Pozita);
            Console.WriteLine("Rroga: " + admini.Rroga + "$");
            admini.CalculateBonus();

            Console.ReadKey();

            }
        }
    }
