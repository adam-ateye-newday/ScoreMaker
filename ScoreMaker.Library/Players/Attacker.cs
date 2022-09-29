using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreMaker.Library
{
    public class Attacker
    {
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Appearances { get; set; }

        public Attacker(int goals, int assists, int appearances)
        {
            Goals = goals;
            Assists = assists;
            Appearances = appearances;
        }
        public Attacker() { }

    }
}
