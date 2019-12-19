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
            entrancedoor.SetDoorLockable = true;
            entrancedoor.SetDoorOpen = true;
            doors.Add(entrancedoor);

            IMasterFloor floor = new Floor();
            floors.Add(floor);

        }

        public void AddRoomDoors()
        {
            if (doors.Count > 3)
            {
                throw new OnlyFourRoomDoorsException();
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

        public void AddFrontDoor()
        {

        }

        //Do we need this? And the interface at all?
        public void MyMethod(ERoomType Entrance)
        {
            throw new NotImplementedException();
        }

        public override void AddWindows()
        {
            throw new NotImplementedException();
        }

        public override void AddDoors()
        {
            throw new NotImplementedException();
        }
    }
}
