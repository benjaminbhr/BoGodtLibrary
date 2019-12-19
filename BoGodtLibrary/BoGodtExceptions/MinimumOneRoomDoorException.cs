using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary.BoGodtExceptions
{
    public class MinimumOneRoomDoorException:Exception
    {
        private const string MINIMUMROOMDOORSEXCEPTION = "You must add at least one room door!";
        public MinimumOneRoomDoorException()
            : base(MINIMUMROOMDOORSEXCEPTION)
        {

        }
    }
}
