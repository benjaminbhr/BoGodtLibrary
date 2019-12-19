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

        }

        public void AddFrontDoors()
        {
            if (doors.Count > 1)
            {
                throw new OnlyOneFrontDoorException();
            }
            else
            {
                doors.Add(new FrontDoor());
            }
        }

        //Do we need this? And the interface at all?
        public void MyMethod(ERoomType Entrance)
        {
            throw new NotImplementedException();
        }

        public override void AddWindows(IMasterWindow window)
        {
            throw new NotImplementedException();
        }
    }
}
