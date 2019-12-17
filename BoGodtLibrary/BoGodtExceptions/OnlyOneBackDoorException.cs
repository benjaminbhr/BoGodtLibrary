using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary.BoGodtExceptions
{
   public class OnlyOneBackDoorException:Exception
    {
        private const string ONLYONEBACKDOOR = "There can only be one backdoor";

        public OnlyOneBackDoorException()
            :base(ONLYONEBACKDOOR)
        {

        }
    }
}
