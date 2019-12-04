using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class LargeWindow : IMasterWindow
    {
        bool IMasterWindow.CanWindowOpen()
        {
            return true;
        }

        EWindowType IMasterWindow.GetWindowType()
        {
            return EWindowType.Large;
        }

        bool IMasterWindow.IsWindowFrosted()
        {
            return false;
        }
    }
}