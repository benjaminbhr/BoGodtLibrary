using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary.BoGodtExceptions
{
    public class OnlyOneFrontDoorException:Exception
    {
        private const string ONLYONEFRONTDOOR = "There can only be one frontdoor";

        public OnlyOneFrontDoorException()
            :base(ONLYONEFRONTDOOR)
        {

        }
    }
}
