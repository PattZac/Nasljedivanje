using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje
{
    class Cat
    {
        private bool opasna;
        public bool Opasna { get => opasna; set => opasna = value; }
        public virtual void Opasnost()
        {
            this.opasna = false;
        }
        public override string ToString()
        {
            return "Maca - opasnost = " + this.opasna + ".";
        }
    }
    class Gepard : Cat
    {
        public override void Opasnost()
        {
            this.Opasna = true;
        }
        public override string ToString()
        {
            return "Gepard - opasnost = "+this.Opasna+".";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Gepard g = new Gepard();
            g.Opasnost();
            Console.WriteLine(g.ToString());
            Cat c = new Cat();
            c.Opasnost();
            Console.WriteLine("\r\n"+c.ToString());
            Console.ReadKey();
        }
    }
}
