using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary.BoGodtExceptions
{
    public class OnlyFiveWindowsException : RoomWindowsException
    {
        private const string ONLYFIVEWINDOWS = "You can maximum add 5 windows to a room!";

        public OnlyFiveWindowsException()
            : base(ONLYFIVEWINDOWS)
        {

        }
    }
}
