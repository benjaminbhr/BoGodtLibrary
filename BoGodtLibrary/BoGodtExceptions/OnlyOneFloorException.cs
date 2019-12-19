using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary.BoGodtExceptions
{
    public class OnlyOneFloorException:Exception
    {
        private const string ONLYONEFLOOR = "There can only be one floor in a room .. How tf did you add another one? Brah .. ";
        public OnlyOneFloorException()
            :base(ONLYONEFLOOR)
        {

        }
    }
}
