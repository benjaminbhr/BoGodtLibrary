using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary.BoGodtExceptions
{
    public class OnlyOneDoorException:Exception
    {
        public OnlyOneDoorException()
            : base()
        {

        }
        public OnlyOneDoorException(string message)
            : base(String.Format("{0} There can only be one door (ﾉಥ益ಥ）ﾉ﻿ ┻━━┻", message))
        {
            
        }
    }
}
