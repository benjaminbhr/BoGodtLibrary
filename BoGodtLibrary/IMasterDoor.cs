using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public interface IMasterDoor
    {
        EDoorType GetDoorType();
        EDoorMaterial SetDoorMaterial
        {
            get;
            set;
        }
        EColor SetDoorColor
        {
            get;
            set;
        }
        bool SetDoorLockable
        {
            get;
            set;
        }
        bool SetDoorOpen
        {
            get;
            set;
        }
    }
}
