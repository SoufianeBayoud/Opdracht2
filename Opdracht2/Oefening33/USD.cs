using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening33
{
    internal class USD
    {
        public double usd { get; set; }

        public USD(double usd)
        {
            this.usd = usd;
        }

        public USD()
        {
            this.usd = usd; 
        }

        public override string ToString()
        {
            return usd.ToString();
        }



    }
    internal class Euro : USD
    {
        public double euro;
        public Euro(double amount) : base(amount)
        {
            euro = amount * 1.03;
        }


        public override string? ToString()
        {
            return euro.ToString();
        }
    }

    internal class Pounds : USD
    {
        public double pounds;
        public Pounds(double amount) : base(amount)
        {
            pounds = amount * 0.90;
        }

        public override string? ToString()
        {
            return pounds.ToString();
        }
    }

    internal class Franken : USD
    {
        public double frank;
        public Franken(double amount) : base(amount)
        {
            frank = amount * 0.99;
        }

        public override string? ToString()
        {
            return frank.ToString();
        }
    }

    internal class Yen : USD
    {
        public double yen;
        public Yen(double amount) : base(amount)
        {
            yen = amount * 145.34;
        }

        public override string? ToString()
        {
            return yen.ToString();
        }
    }

    internal class Rupees : USD
    {
        public double rupees;
        public Rupees(double amount) : base(amount)
        {
            rupees = amount * 82.83;
        }

        public override string? ToString()
        {
            return rupees.ToString();
        }
    }

}
