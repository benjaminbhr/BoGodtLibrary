using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public abstract class MasterDoor : IMasterDoor
    {
        public abstract EDoorMaterial GetDoorMaterial();
        public abstract EColor GetColor();
        public abstract bool CanDoorOpen();
        public abstract EDoorType GetDoorType();
        public abstract bool IsLockable();
    }
}
