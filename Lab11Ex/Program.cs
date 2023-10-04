using System;
using Lab11Ex.Autoturisme;
using Lab11Ex.Pompe;
/*
 
 Scrieti un program care va modela statii de pompare.
O statie de pompare poate pune la dispozitia clientilor mai multe tipuri de combustibil
• Benzina
• Diesel
• GPL
• Electricitate
Autovehiculele
Autovehiculele sunt caracterizate de model, id si o metoda ce va produce descrierea completa a
autovehiculului. Ele pot fi de mai multe tipuri
• Benzina - capabile sa fie alimentate doar cu benzina
• Diesel - capabile sa fie alimentate doar cu diesel
• GPL - capabile sa fie alimentate atat cu benzina cat si cu GPL
• Electrice - capabile sa fie alimentate doar cu electricitate
• Plug-in hybrid- capabile sa fie alimentate atat cu benzina cat si cu electricitate
Statiile de pompare
Statiile de pompare sunt de mai multe tipuri
• Clasice
o Pot alimenta doar Benzina, Diesel si GPL
• Hibride
o Pot alimenta toate tipurile de combustibil
Statiile de pompare vor detine mai multe metode specifice fiecarui tip de combustibil suportat.
Metodele vor simula alimentarea unui autovehicul cu un combustibilul specific.
Aceste metode vor primi ca parametru atat autovehiculul cat si cantitatea de combustibil dorita.
Apelul metodelor va afisa pe ecran descrierea completa a autovehiculului si cantitatea alimentata.
Statiile de pompare vor avea o cantitate infinita de combustibil.
Instantiati statii de pompare, creați auovehicule si alimentati-le la statiile de pompare instantiate.*/

namespace Lab11Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var opel = new Hibrid("Corsa");
            var pompaHibrida = new PompaHibrid();
            var cisterna = new Cisterna("Cisterna");
            // pompaHibrida.AlimenteazaDisel(200, opel);
            pompaHibrida.AlimenteazaDisel(200, cisterna);
            pompaHibrida.AlimenteazaBenzia(100, cisterna);
           
            
            
        }
    }
}
