using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary.BoGodtExceptions
{
    public class OnlyFourRoomDoorsException:Exception
    {
        private const string FOURROOMDOORSEXCEPTION = "There can only be a maximum of four room doors";
        public OnlyFourRoomDoorsException()
            : base(FOURROOMDOORSEXCEPTION)
        {

        }
    }
}
