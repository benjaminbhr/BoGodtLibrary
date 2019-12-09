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
        EWindowMaterial Setwindowmaterial
        {
            get;
            set;
        }
        EWindowCasement Setwindowcasement
        {
            get;
            set;
        }
        EColor Setcolor
        {
            get;
            set;
        }
        bool Setwindowopen
        {
            get;
            set;
        }
        bool Setwindowfrosted
        {
            get;
            set;
        }
    }
}
