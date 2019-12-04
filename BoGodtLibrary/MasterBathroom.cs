using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public abstract class MasterBathroom : IMasterBathroom
    {
        public string FloorColor()
        {
            return "";
        }
        public string Window()
        {
            return "";
        }
        int MaxWindows;
    }
}