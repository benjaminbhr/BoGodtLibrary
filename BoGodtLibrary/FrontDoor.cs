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
        public override EDoorMaterial GetDoorMaterial()
        {
            return EDoorMaterial.Wooden;
        }
        public override bool CanDoorOpen()
        {
            return true;
        }

        public override EColor GetColor()
        {
            throw new NotImplementedException();
        }

        public override bool IsLockable()
        {
            throw new NotImplementedException();
        }
    }
}
