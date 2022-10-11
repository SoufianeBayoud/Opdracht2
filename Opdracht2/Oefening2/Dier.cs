using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    internal abstract class Dier
    {
        public int Gewicht { get; set; }
        private string Uitspraak { get; set; }
        private string Geluid { get; set; }


        public Dier(string uitspraak, int gewicht, string geluid)
        {
            this.Uitspraak = uitspraak;
            this.Gewicht = gewicht;
            this.Geluid = geluid;
        }

        public string Zegt()
        {
            return "uitspraak " + Uitspraak;
        }
        public string Weegt()
        {
            return " weegt " + Gewicht;
        }

    }
}
