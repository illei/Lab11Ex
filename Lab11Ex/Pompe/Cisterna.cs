using Lab11Ex.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11Ex.Pompe
{
    class Cisterna :PompaClasica, IDisel, IBenzina
    {
        public int RezervorBenzina { get; set; }
        public int RezervorDisel { get; set; }
        public string Nume { get; set; }

        public Cisterna(string nume)
        {
            this.RezervorBenzina = 0;
            this.RezervorDisel = 0;
            this.Nume = nume;
        }


        public override string ToString()
        {
            return "";
        }

        public void IncarcaRezervorBenzina(int cantitate)
        {
            if (this.RezervorDisel== 0)
            {
                this.RezervorBenzina += cantitate;
                Console.WriteLine("A-ti incarcat Cisterna cu Benzina");
            }
            else
            {
                Console.WriteLine("Exista de deja Disel in Cisterna");
                return;
                
            }
        }

        public void IncarcaRezervorDisel(int cantitate)
        {
            if (this.RezervorBenzina == 0)
            {
                this.RezervorDisel += cantitate;
                Console.WriteLine("A-ti incarcat Cisterna cu Disel");
            }
            else
            {
                Console.WriteLine("Exista de deja Benzina in Cisterna");
                return;
               
            }
        }

        public override void AlimenteazaBenzia(int litri, IBenzina autovehicul)
        {
            if (RezervorBenzina >= litri)
            {
                base.AlimenteazaBenzia(litri, autovehicul);
            }
            else
            {
                Console.WriteLine("nu exista suficienta benzina in cisterna");
                return;
            }
          
        }

        public override void AlimenteazaDisel(int litri, IDisel autovehicul)
        {
            if (RezervorDisel>= litri)
            {
                base.AlimenteazaDisel(litri, autovehicul);
            }
            else
            {
                Console.WriteLine("Cisterna nu are destul Disel");
                return;
            }
        }
        public override void AlimenteazaGPL(int litri, IGPL autovehicul)
        {
            Console.WriteLine("Indisponibil");
        }

    }
}
