using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public abstract class MasterDoor : IMasterDoor
    {
        public abstract int DoorMaterial();
        public abstract int DoorType();
        public abstract bool CanDoorOpen();
        public abstract EDoorType GetDoorType();
    }
}
