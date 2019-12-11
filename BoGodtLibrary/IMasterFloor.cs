using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public interface IMasterFloor
    {
        EFloorType SetFloorType
        {
            get;
            set;
        }
        EColor SetFloorColor
        {
            get;
            set;
        }
    }
}