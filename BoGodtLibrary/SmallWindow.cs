using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class SmallWindow : MasterWindow
    {

        public override EWindowType GetWindowType()
        {
            return EWindowType.Small;
        }
        public SmallWindow()
        {
            windowCasement = EWindowCasement.CasementOne;
        }

    }
}