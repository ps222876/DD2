using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DD2.Classes
{
    internal class Buitenwedstrijd : Wedstrijd, ICoronaCheckEvenement
    {

        private bool doorstroom { get; set; }
        internal bool Doorstroom { get; set; }

        public bool Buiten()
        {
            return true;
        }

        public bool CoronaCheckRequired()
        {
            return true;
        }

        public bool VastePlaats()
        {
            return false;
        }
    }
}
