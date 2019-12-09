using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class BackDoor : MasterDoor
    {
        public EDoorType GetDoorType()
        {
            return EDoorType.BackDoor;
        }

        public BackDoor()
        {

        }
    }
}
