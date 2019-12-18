﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary.BoGodtExceptions
{
   public class OnlyOneBackDoorException:Exception
    {
        public OnlyOneBackDoorException(string backDoorMessage)
            :base(backDoorMessage)
        {

        }
    }
}
