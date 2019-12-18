using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary.BoGodtExceptions
{
    public abstract class RoomWindowsException : Exception
    {
        

        protected RoomWindowsException(string msg)
            : base(msg)
        {

        }
    }
}
