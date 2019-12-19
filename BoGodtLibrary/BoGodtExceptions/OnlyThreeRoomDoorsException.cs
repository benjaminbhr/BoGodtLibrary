using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary.BoGodtExceptions
{
    public class OnlyThreeRoomDoorsException:Exception
    {
        private const string THREEROOMDOORSEXCEPTION = "There can only be a maximum of three room doors";
        public OnlyThreeRoomDoorsException()
            : base(THREEROOMDOORSEXCEPTION)
        {

        }
    }
}
