﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class Room : MasterRoom
    {
        public override ERoomType GetRoomType()
        {
            return ERoomType.Room;
        }
    }
}
