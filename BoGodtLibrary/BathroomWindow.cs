using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class BathroomWindow : SmallWindow
    {
        public override bool IsWindowFrosted()
        {
            return true;
        }
        public override bool CanWindowOpen()
        {
            return false;
        }
    }
}
