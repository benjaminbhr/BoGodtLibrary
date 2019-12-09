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
        EWindowMaterial windowMaterial
        {
            get;
            set;
        }
        EWindowCasement windowCasement
        {
            get;
            set;
        }
        EColor color
        {
            get;
            set;
        }
        bool windowOpen
        {
            get;
            set;
        }
        bool windowFrosted
        {
            get;
            set;
        }
    }
}
