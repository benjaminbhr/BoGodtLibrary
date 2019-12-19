using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary.BoGodtExceptions
{
    class CantBeThisFloorTypeException:Exception
    {
        private const string CANTBETHISFLOORTYPE = "You cant use this floor type for this room";
        public CantBeThisFloorTypeException()
            :base(CANTBETHISFLOORTYPE)
        {

        }
    }
}