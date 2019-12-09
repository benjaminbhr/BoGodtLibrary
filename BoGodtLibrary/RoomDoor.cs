using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class RoomDoor:MasterDoor
    {
        public EDoorType GetDoorType()
        {
            return EDoorType.RoomDoor;
        }

        public RoomDoor()
        {

        }
    }
}
