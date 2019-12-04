using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public interface IMasterWindow
    {
        EWindowType GetWindowType();
        EWindowMaterial GetWindowMaterial();
        EColor GetColor();
        bool Windowopen { get; set; }
        bool IsWindowFrosted();
    }
}
