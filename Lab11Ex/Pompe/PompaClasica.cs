using Lab11Ex.Autoturisme;
using Lab11Ex.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11Ex.Pompe
{
    class PompaClasica
    {
        public virtual void AlimenteazaBenzia(int litri,IBenzina autovehicul)
        {
            
            
                Console.WriteLine("A-ti inceput alimentarea cu Benzina");
                autovehicul.IncarcaRezervorBenzina(litri);
                Console.WriteLine(autovehicul.ToString());
                Console.WriteLine($"A-ti alimentant{litri} litri de Benzina ");
            
           
        }
       
        public virtual void AlimenteazaDisel(int litri, IDisel autovehicul)
        {
            Console.WriteLine("A-ti inceput alimentarea cu Disel");
            autovehicul.IncarcaRezervorDisel(litri);
            Console.WriteLine(autovehicul.ToString());
            Console.WriteLine($"A-ti alimentant{litri} litri de Disel ");


        }
        public virtual  void AlimenteazaGPL(int litri, IGPL autovehicul)
        {
            Console.WriteLine("A-ti inceput alimentarea  cu GPL");
            autovehicul.IncarcaButelieGPL(litri);
            Console.WriteLine(autovehicul.ToString());
            Console.WriteLine($"A-ti alimentant{litri} litri de GPL ");
        }
    }
}
