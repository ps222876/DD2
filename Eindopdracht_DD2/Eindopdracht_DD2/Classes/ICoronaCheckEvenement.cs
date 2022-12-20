using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DD2.Classes
{
    internal interface ICoronaCheckEvenement
    {
        internal bool VastePlaats();

        internal bool Buiten();

        internal bool CoronaCheckRequired();
    }
}
