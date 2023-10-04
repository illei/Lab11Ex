using Lab11Ex.Interfaces;
using System;

namespace Lab11Ex.Autoturisme
{
    class Disel : Autoturism,IDisel
    {
        public Disel(string nume)
        {
            this.Nume = nume;
            
        }

        public void IncarcaRezervorDisel(int cantitate)
        {
            Console.WriteLine( $"ALimentam cu Disel");
        }

        public override string ToString()
        {
            return $"Autoturismul cu numele {this.Nume} si id-ul {this.Id}";
        }
    }
}
