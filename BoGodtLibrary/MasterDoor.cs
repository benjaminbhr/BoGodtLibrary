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
        public abstract EDoorType GetDoorType();

        private bool _SetDoorOpen;
        public bool SetDoorOpen
        {
            get => _SetDoorOpen;
            set => _SetDoorOpen = value;
        }

        private bool _SetDoorLockable;
        public bool SetDoorLockable
        {
            get => _SetDoorLockable;
            set => _SetDoorLockable = value;
        }
    }
}
