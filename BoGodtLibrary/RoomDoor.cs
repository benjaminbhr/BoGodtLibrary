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
        public override EDoorMaterial GetDoorMaterial()
        {
            return EDoorMaterial.Metallic;
        }
        public override bool CanDoorOpen()
        {
            return true;
        }
        public override EColor GetColor()
        {
            return EColor.ColorWed;
        }
        public override bool IsLockable()
        {
            return false;
        }
    }
}
