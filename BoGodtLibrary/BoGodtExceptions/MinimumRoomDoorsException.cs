using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary.BoGodtExceptions
{
    public class MinimumRoomDoorsException:Exception
    {
        private const string minimumRoomDoor = "There can only be a minimum of one room door";

        public MinimumRoomDoorsException()
            :base(minimumRoomDoor)
        {

        }
    }
}
