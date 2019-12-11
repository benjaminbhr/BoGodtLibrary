using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public abstract class MasterDoor : IMasterDoor
    {
        private EDoorMaterial _SetDoorMaterial = EDoorMaterial.WoodMahogany;
        public EDoorMaterial SetDoorMaterial
        {
            get => _SetDoorMaterial;
            set => _SetDoorMaterial = value;
        }

        private EColor doorColor = EColor.ColorWhite; 
        public EColor SetDoorColor
        {
            get => doorColor;
            set => doorColor = value;
        }

        private EDoorType DoorType = EDoorType.RoomDoor;
        public EDoorType SetDoorType
        {
            get => DoorType;
            set => DoorType = value;
        }

        private bool DoorOpen = true;
        public bool SetDoorOpen
        {
            get => DoorOpen;
            set => DoorOpen = value;
        }

        private bool DoorLockable = false;
        public bool SetDoorLockable
        {
            get => DoorLockable;
            set => DoorLockable = value;
        }
    }
}
