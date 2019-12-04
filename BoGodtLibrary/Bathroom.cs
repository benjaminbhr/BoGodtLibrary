using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class Bathroom : MasterRoom
    {
        public override ERoomType GetRoomType()
        {
            return ERoomType.Bathroom;
        }
        public bool IsNew()
        {
            return true;
        }
        public void AddWindows()
        {
            if (MaxWindows >= 1)
            {
                throw new Exception("Too many windows :(");
            }
            else
            {
                MediumWindow vindue = new MediumWindow();
                windows.Add(vindue);
            }
        }

        int MaxWindows = 0;
    }
}
