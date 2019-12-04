using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class RoomDoor:MasterDoor
    {
        public override EDoorType GetDoorType()
        {
            return EDoorType.RoomDoor;
        }
        public override int DoorMaterial()
        {
            return 5;
        }
        public override int DoorType()
        {
            return 6;
        }
        public override bool CanDoorOpen()
        {
            return true;
        }
    }
}
