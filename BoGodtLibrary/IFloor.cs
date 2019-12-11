﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public interface IFloor
    {
        EFloorType floorType
        {
            get;
            set;
        }
        EColor color
        {
            get;
            set;
        }
    }
}