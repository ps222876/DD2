using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DD2.Classes
{
    public abstract class Uitje : ICoronaCheckEvenement
    {
        internal String Naam { get; set; }
        internal DateTime StartDatum { get; set; }
        internal bool Doorstroom { get; set; }
        internal bool BinnenEvent { get; set; }

        public bool Buiten()
        {
            return false;
        }

        public bool CoronaCheckRequired()
        {
            return true;
        }

        public bool VastePlaats()
        {
            return true;
        }
    }
}
