using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreMaker.Library
{
    public class Goalkeeper
    {
        public int Saves { get; set; }
        public int Cleansheets { get; set; }
        public int Conceded { get; set; }
        public int Sweeps { get; set; }
        public int Appearances { get; set; }

        public Goalkeeper(int saves, int cleansheets, int conceded, int sweeps, int appearances)
        {
            Saves = saves;
            Cleansheets = cleansheets;
            Conceded = conceded;
            Sweeps = sweeps;
            Appearances = appearances;
        }
        public Goalkeeper() { }
    }
}
