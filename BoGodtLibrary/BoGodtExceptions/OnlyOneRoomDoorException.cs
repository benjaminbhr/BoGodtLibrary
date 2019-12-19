using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary.BoGodtExceptions
{
    class OnlyOneRoomDoorException:Exception
    {
        private const string ONEROOMDOOREXCEPTION = "There can only be a maximum of one room door";
        public OnlyOneRoomDoorException()
            :base(ONEROOMDOOREXCEPTION)
        {

        }
    }
}
