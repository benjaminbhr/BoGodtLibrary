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
        EDoorMaterial DoorMaterial
        {
            get;
            set;
        }
        EColor DoorColor
        {
            get;
            set;
        }
        bool DoorLockable
        {
            get;
            set;
        }
        bool DoorOpen
        {
            get;
            set;
        }
    }
}
