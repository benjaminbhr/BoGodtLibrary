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
            throw new NotImplementedException();
        }

        public Entrance()
        {
            IMasterDoor entrancedoor = new FrontDoor();
            entrancedoor.SetDoorLockable = true;
            entrancedoor.SetDoorOpen = true;
            doors.Add(entrancedoor);
        }

        //Do we need this? And the interface at all?
        public void MyMethod(ERoomType Entrance)
        {
            throw new NotImplementedException();
        }
    }
}
