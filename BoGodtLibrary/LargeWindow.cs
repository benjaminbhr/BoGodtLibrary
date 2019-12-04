using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class LargeWindow : IMasterWindow
    {
        public void CanWindowOpen(bool canwindowopen)
        {
            throw new NotImplementedException();
        }

        public EColor GetColor()
        {
            throw new NotImplementedException();
        }

        public EWindowMaterial GetWindowMaterial()
        {
            throw new NotImplementedException();
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