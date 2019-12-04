using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    interface IMasterWindow
    {
        EWindowType GetWindowType();
        EWindowMaterial GetWindowMaterial();
        EColor GetColor();
        void CanWindowOpen(bool canwindowopen);
        bool IsWindowFrosted(bool iswindowfrosted);
    }
}
