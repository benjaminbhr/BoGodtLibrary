using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class SmallWindow : MasterWindow
    {
        public override bool CanWindowOpen()
        {
            return true;
        }
        public override EWindowType GetWindowType()
        {
            return EWindowType.Small;
        }
        public override bool IsWindowFrosted()
        {
            return false;
        }
    }
}