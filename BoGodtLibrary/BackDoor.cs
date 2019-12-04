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
            throw new NotImplementedException();
        }
    }
}
