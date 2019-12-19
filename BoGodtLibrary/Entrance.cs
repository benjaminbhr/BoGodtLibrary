using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoGodtLibrary.BoGodtExceptions;

namespace BoGodtLibrary
{
    public class Entrance : MasterRoom
    {
        public override ERoomType GetRoomType()
        {
            return ERoomType.Entrance;
        }
        
        public Entrance()
        {
            IMasterDoor entrancedoor = new FrontDoor();
            entrancedoor.DoorLockable = true;
            entrancedoor.DoorOpen = true;
            doors.Add(entrancedoor);
        }

        public void AddDoors()
        {
            if (doors.Count > 3)
            {
                throw new OnlyThreeRoomDoorsException();
            }
            if (doors.Count <= 0)
            {
                throw new MinimumOneRoomDoorException();
            }
            else
            {
                doors.Add(new RoomDoor());
            }
        }

        public override void AddWindows(IMasterWindow window)
        {
            throw new NoWindowsException();
        }
        public override void AddDoors(IMasterDoor door)
        {
            throw new OnlyOneFrontDoorException();
        }
        public override void AddFloor(IMasterFloor floor)
        {
            floors.Add(floor);
        }
    }
}
