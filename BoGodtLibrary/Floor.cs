﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class Floor : MasterFloor
    {
        public EFloorType GetFloorType()
        {
            return EFloorType.Click;
        }
    }
}
