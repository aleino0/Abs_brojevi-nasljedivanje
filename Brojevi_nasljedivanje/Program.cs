using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brojevi_nasljedivanje
{
    public class Brojevi
    {
        double broj;

        public double Broj { get => broj; set => broj = value; }


        public Brojevi (double broj1)
        {
            broj = broj1;
        }
        public virtual double ApsVrijednost()
        {
            return 0;
        }

    }
    class Cijeli : Brojevi
    {
        public Cijeli(double broj1) :base(broj1) {}
    }
        class Pozitivni  : Cijeli
        {
            double _broj;
            public Pozitivni (double broj1): base(broj1)
            {
                _broj = broj1;
            }
            public override string ToString()
            {
            return "Apsolutna vrijednos broja 100 je " + Math.Abs(_broj);
            }
        }
        class Negativni : Cijeli
        {
            double _broj;
            public Negativni(double broj1) : base(broj1)
            {
                _broj = broj1;
            }
            public override string ToString()
            {
                return "Apsolutna vrijednos broja -100 je " + Math.Abs(_broj);
            }
        }

    class Decimalni : Brojevi
    {
        double _broj;
        public Decimalni(double broj1) : base(broj1)
        {
            _broj = broj1;
        }
        public override string ToString()
        {
            return "Apsolutna vrijednos broja 100.45 je " + Math.Abs(_broj);
        }
    }


    internal class Program
    {
        static void Main()
        {
            Pozitivni x = new Pozitivni(100);
            Negativni y = new Negativni(-100);
            Decimalni z = new Decimalni(100.45);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);


            Console.ReadKey();
        }
    }
}
