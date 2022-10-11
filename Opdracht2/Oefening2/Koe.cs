using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    internal class Koe : Dier
    {
        public SoundPlayer GeluidKoe = new SoundPlayer(@"C:\Users\Administrator\source\repos\Opdracht2\bin\Debug\cow.wav");
        public Koe(int gewicht, string uitspraak) : base(uitspraak, gewicht, "boe")
        {

        }

        public string Geluid()
        {
            GeluidKoe.Play();
            return base.Zegt();
        }
    }
}
