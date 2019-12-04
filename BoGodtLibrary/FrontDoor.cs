using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class FrontDoor:MasterDoor
    {
        public override EDoorType GetDoorType()
        {
            return EDoorType.FrontDoor;
        }
        public override int DoorMaterial()
        {
            return 1;
        }
        public override int DoorType()
        {
            return 2;
        }
        public override bool CanDoorOpen()
        {
            return true;
        }
    }
}
