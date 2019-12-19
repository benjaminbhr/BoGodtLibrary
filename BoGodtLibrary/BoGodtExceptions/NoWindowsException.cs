using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary.BoGodtExceptions
{
    public class NoWindowsException : RoomWindowsException
    {
        private const string NOWINDOWS = "You can maximum add 1 window to this room";

        public NoWindowsException()
            : base(NOWINDOWS)
        {

        }
    }
}
