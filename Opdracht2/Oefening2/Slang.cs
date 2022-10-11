using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    internal class Slang : Dier
    {
        public SoundPlayer GeluidSlang = new SoundPlayer(@"C:\Users\Administrator\source\repos\Opdracht2\bin\Debug\snake.wav");

        public Slang(int gewicht, string uitspraak) : base(uitspraak, gewicht, "ssj")
        {

        }

        public string Geluid()
        {
            GeluidSlang.Play();
            return base.Zegt();
        }

    }
}
