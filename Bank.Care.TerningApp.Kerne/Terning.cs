using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Care.TerningApp.Kerne
{
    public class Terning : IComparable<Terning>
    {
                
        private static Random rnd = new Random();
        public int Værdi { get; private set; }

        public Terning()
        {
            
            this.Ryst();
        }

        public Terning(int værdi)
        {
            
            if (værdi >= 1 && værdi <= 6)
                this.Værdi = værdi;
            else
                throw new ApplicationException("Forkert værdi");
        }

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        public override string ToString()
        {
            return "[" + this.Værdi + "]";
        }

        public int CompareTo(Terning other)
        {
            return this.Værdi - other.Værdi;
        }
    }
}
