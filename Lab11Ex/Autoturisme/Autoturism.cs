using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11Ex.Autoturisme
{
    abstract class Autoturism
    {

        protected  string Nume { get; set; }
        protected readonly  Guid Id = Guid.NewGuid();
        protected int Rezervor { get; set; }

        public abstract override string ToString();
        
    }
}
