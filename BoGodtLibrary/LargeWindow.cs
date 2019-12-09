using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class LargeWindow : MasterWindow
    {

        public override EWindowType GetWindowType()
        {
            return EWindowType.Large;
        }
        public LargeWindow()
        {
            windowCasement = EWindowCasement.CasementThree;
        }
    }
}