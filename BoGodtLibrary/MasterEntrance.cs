using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    abstract class MasterEntrance:IMasterEntrance
    {
        public abstract string EntranceColor();

        public abstract string FloorColor();

        List<IMasterEntrance> ListEntrance = new List<IMasterEntrance>();
    }
}
