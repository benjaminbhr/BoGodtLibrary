using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class BackDoor:MasterDoor
    {
        public override EDoorType GetDoorType()
        {
            return EDoorType.BackDoor;
        }
        public override int DoorMaterial()
        {
            return 3;
        }
        public override int DoorType()
        {
            return 4;
        }
        public override bool CanDoorOpen()
        {
            return true;
        }
    }
}
