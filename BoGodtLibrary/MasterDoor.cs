using BoGodtLibrary.BoGodtExceptions;
using System.Collections.Generic;

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
        public abstract EDoorType GetDoorType();

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

        List<IMasterDoor> doors = new List<IMasterDoor>();
        public void AddDoors(EDoorType doorType)
        {
            switch (doorType)
            {
                case EDoorType.FrontDoor:
                    IMasterDoor frontdoor = new FrontDoor();
                    doors.Add(frontdoor);
                    break;
                case EDoorType.BackDoor:
                    IMasterDoor backdoor = new BackDoor();
                    doors.Add(backdoor);
                    break;
                case EDoorType.RoomDoor:
                    IMasterDoor roomdoor = new RoomDoor();
                    doors.Add(roomdoor);
                        break;
                default:
                    break;
            }
        }
    }
}
