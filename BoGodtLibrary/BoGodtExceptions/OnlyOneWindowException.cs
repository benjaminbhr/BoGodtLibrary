using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoGodtLibrary;

namespace BoGodtLibrary.BoGodtExceptions
{
    public class OnlyOneWindowsException : RoomWindowsException
    {
        private const string ONLYONEWINDOWS = "You can maximum add 1 window to this room";

        public OnlyOneWindowsException()
            : base(ONLYONEWINDOWS)
        {

        }
    }
}