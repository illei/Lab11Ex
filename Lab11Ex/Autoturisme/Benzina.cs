using Lab11Ex.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11Ex.Autoturisme
{
    class Benzina :Autoturism,IBenzina
    {
        public Benzina(string nume)
        {
            this.Nume = nume;
           
        }
        public override string ToString()
        {
            return $"Autoturismul cu numele {this.Nume} si id-ul {this.Id}";
        }
        

        public void IncarcaRezervorBenzina(int cantitate)
        {
            Console.WriteLine( $"Alimnetam cu Benzina");
        }
    }
}
