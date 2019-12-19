using BoGodtLibrary.BoGodtExceptions;
using System.Collections.Generic;

namespace BoGodtLibrary
{
    public abstract class MasterDoor : IMasterDoor
    {
        private EDoorMaterial _DoorMaterial = EDoorMaterial.WoodMahogany;
        public EDoorMaterial DoorMaterial
        {
            get => _DoorMaterial;
            set => _DoorMaterial = value;
        }

        private EColor _DoorColor = EColor.ColorWhite;
        public EColor DoorColor
        {
            get => _DoorColor;
            set => _DoorColor = value;
        }

        public abstract EDoorType GetDoorType();

        private bool _DoorOpen = true;
        public bool DoorOpen
        {
            get => _DoorOpen;
            set => _DoorOpen = value;
        }

        private bool _DoorLockable = false;
        public bool DoorLockable
        {
            get => _DoorLockable;
            set => _DoorLockable = value;
        }
        /*
        List<IMasterDoor> roomdoors = new List<IMasterDoor>();
        public void AddDoors(EDoorType doorType)
        {
            switch (doorType)
            {
                case EDoorType.RoomDoor:
                    IMasterDoor roomdoor = new RoomDoor();
                    roomdoors.Add(roomdoor);
                        break;
                default:
                    break;
            }
        }
        */
    }
}
