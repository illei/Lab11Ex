using Lab11Ex.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11Ex.Pompe
{
    class PompaHibrid :PompaClasica
    {
        public void AlimenteazaCurent(int KVh, ICurent autovehicul)
        {
            Console.WriteLine("A-ti inceput incarcarea bateriei");
            autovehicul.IncarcaBateria(KVh);
            Console.WriteLine(autovehicul.ToString());
            Console.WriteLine($"A-ti Incartcat bateria cu {KVh} Kv/h");
        }
    }
}
