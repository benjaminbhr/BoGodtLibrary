using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary.BoGodtExceptions
{
    public class MaximumRoomDoorsException:Exception
    {
        private const string maximumRoomDoor = "There can only be a maximum of four room doors";

        public MaximumRoomDoorsException()
            :base(maximumRoomDoor)
        {

        }
    }
}
