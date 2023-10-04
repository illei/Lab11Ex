using Lab11Ex.Interfaces;
using System;

namespace Lab11Ex.Autoturisme
{
    class GPL : Benzina,IGPL,IBenzina
    {
        public GPL(string nume):base(nume)
        {
          
            
        }

        

        public void IncarcaButelieGPL(int cantitate)
        {
            Console.WriteLine($"ALimentam cu GPL");
        }

        public override string ToString()
        {
            return $"Autoturismul cu numele {this.Nume} si id-ul {this.Id}";
        }
    }
}
