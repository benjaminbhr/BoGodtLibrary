﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class Kitchen : MasterRoom, IKitchen
    {
        public override ERoomType GetRoomType()
        {
            return ERoomType.Kitchen;
        }
        public bool IsNew()
        {
            return true;
        }
        public override void AddWindows(IMasterWindow window)
        {
            if (MaxWindows >= 1)
            {
                throw new Exception("Too many windows :(");
            }
            else
            {
                windows.Add(new SmallWindow());
                MaxWindows++;
            }
        }
        int MaxWindows = 0;

        //  public Kitchen(IMasterFloor floor)
        //: base()
        //{
        //  this.floors.Add(floor.SetFloorType);

        //}
        IMasterRoom floorType = new Kitchen();
        
    }
}
