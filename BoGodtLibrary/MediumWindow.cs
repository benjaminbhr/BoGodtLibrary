using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class MediumWindow : MasterWindow
    {

        public override EWindowType GetWindowType()
        {
            return EWindowType.Medium;
        }
        public override EWindowCasement GetWindowCasement()
        {
            return EWindowCasement.CasementTwo;
        }
    }
}
