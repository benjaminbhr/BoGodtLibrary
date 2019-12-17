using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary.BoGodtExceptions
{
    public class MaxRoomsException : Exception
    {
        int roomAmount;

        public RoomException(string roomAmount)
            :base(roomAmount)
        {
            
        }

    }
}