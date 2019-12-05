using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public abstract class MasterWindow : IMasterWindow
    {
        public bool Setwindowopen
        {
            get => Setwindowopen;
            set => Setwindowopen = value;
        }
        public bool Setwindowfrosted
        {
            get => Setwindowfrosted;
            set => Setwindowfrosted = value;
        }
        public abstract EWindowMaterial GetWindowMaterial();
        public abstract EColor GetColor();
        public abstract EWindowType GetWindowType();
        
    }
}