using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary.BoGodtExceptions
{
    class OnlyTwoRoomDoorsException:Exception
    {
        private const string TWOROOMDOORSEXCEPTION = "There can only be a maximum of two room doors";
        public OnlyTwoRoomDoorsException()
            : base(TWOROOMDOORSEXCEPTION)
        {

        }
    }
}
