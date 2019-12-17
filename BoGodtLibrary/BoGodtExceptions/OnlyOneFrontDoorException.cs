using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary.BoGodtExceptions
{
    public class OnlyOneFrontDoorException:Exception
    {

        public OnlyOneFrontDoorException()
            :base()
        {

        }

        public OnlyOneFrontDoorException(string frontDoorMessage)
            :base(string.Format("There can only be one frontdoor", frontDoorMessage))
        {

        }
    }
}
