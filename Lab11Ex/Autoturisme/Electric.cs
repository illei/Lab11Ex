using Lab11Ex.Interfaces;
using System;

namespace Lab11Ex.Autoturisme
{
    class Electric : Autoturism, ICurent
    {
        public Electric(string nume)
        {
            this.Nume = nume;
           
        }

        public void IncarcaBateria(int cantitate)
        {
            Console.WriteLine($"Incarcam Baterie");
        }

        public override string ToString()
        {
            return $"Autoturismul cu numele {this.Nume} si id-ul {this.Id}";
        }
    }
}
