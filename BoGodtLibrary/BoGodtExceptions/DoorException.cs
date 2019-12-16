using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary.BoGodtExceptions
{
    public class DoorException:Exception
    {

        public DoorException()
            :base()
        {

        }

        public DoorException(string doorMessage)
            :base(string.Format("There can only be one door", doorMessage))
        {

        }
    }
}
