using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DD2.Classes
{
    internal class BioscoopUitje : Uitje
    {
        private DateTime aanvangsTijdstip { get; set; }
        internal DateTime AanvangsTijdstip { get; set; }

        private TimeSpan duur { get; set; }
        internal TimeSpan Duur { get; set; }

        private string film { get; set; }
        internal string Film { get; set; }

        private string zaal { get; set; }
        internal string Zaal { get; set; }

        private string stoel { get; set; }
        internal string Stoel { get; set; }

    }
}
