using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class MediumWindow : MasterWindow
    {
        public override EColor GetColor()
        {
            throw new NotImplementedException();
        }

        public override EWindowMaterial GetWindowMaterial()
        {
            throw new NotImplementedException();
        }

        public override EWindowType GetWindowType()
        {
            return EWindowType.Medium;
        }

    }
}
