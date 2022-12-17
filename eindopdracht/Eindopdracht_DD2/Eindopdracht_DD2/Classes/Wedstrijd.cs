using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DD2.Classes
{
    public abstract class Wedstrijd
    {
        private bool doorstroom { get; set; }
        internal bool Doorstroom { get; set; }

        internal string Naam { get; set; }
        internal DateTime StartDatum { get; set; }
        internal TimeSpan WedstrijdDuur { get; set; }

       
    }

}
