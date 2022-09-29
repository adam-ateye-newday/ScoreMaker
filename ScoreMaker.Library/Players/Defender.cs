using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreMaker.Library
{
    public class Defender
    {
        public int Clearances { get; set; }
        public int Interceptions { get; set; }
        public int Appearances { get; set; }

        public Defender(int clearances, int interceptions, int appearances)
        {
            Clearances = clearances;
            Interceptions = interceptions;
            Appearances = appearances;
        }
        public Defender() { }
    }
}
