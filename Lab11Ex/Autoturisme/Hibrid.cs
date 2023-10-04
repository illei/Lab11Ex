using Lab11Ex.Interfaces;
using System;

namespace Lab11Ex.Autoturisme
{
    class Hibrid : Benzina,IBenzina,ICurent
    {
        public Hibrid(string nume) : base(nume)
        {
            this.Nume = nume;
            
        }

        
        public void IncarcaBateria(int cantitate)
        {
            Console.WriteLine($"Incarcam Bateria");
        }
        public override string ToString()
        {
            return $"Autoturismul cu numele {this.Nume} si id-ul {this.Id}";
        }
    }
}
