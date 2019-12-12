using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    class Entrance:MasterRoom
    {
        public override ERoomType GetRoomType()
        {
            return ERoomType.Entrance;
        }

        public Entrance()
        {
            IMasterDoor entrancedoor = new FrontDoor();
            entrancedoor.SetDoorLockable = true;
            entrancedoor.SetDoorOpen = true;
            doors.Add(entrancedoor);

            IMasterFloor floor = new Floor();
            floors.Add(floor);
            
        }

        //Do we need this? And the interface at all?
        public void MyMethod(ERoomType Entrance)
        {
            throw new NotImplementedException();
        }

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
