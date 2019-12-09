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
        public override EDoorMaterial GetDoorMaterial()
        {
            return EDoorMaterial.Glass;
        }
        public override EColor GetColor()
        {
            return EColor.ColorRed;
        }

        public override bool IsLockable()
        {
            return false;
        }
    }
}
