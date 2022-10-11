using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    internal class Varken : Dier
    {
        public SoundPlayer GeluidVarken = new SoundPlayer(@"C:\Users\Administrator\source\repos\Opdracht2\bin\Debug\oink.wav");

        public Varken(int gewicht, string uitspraak) : base(uitspraak, gewicht, "boe")
        {

        }

        public string Geluid()
        {
            GeluidVarken.Play();
            return base.Zegt();
        }
    }
}
