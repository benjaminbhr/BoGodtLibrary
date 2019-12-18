using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary.BoGodtExceptions
{
    public class MinimumOneWindowException : RoomWindowsException
    {
        private const string MINIMUMONEWINDOW = "You have to add at least one window to a room!";

        public MinimumOneWindowException()
            : base(MINIMUMONEWINDOW)
        {

        }
    }
}
