using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public abstract class MasterWindow : IMasterWindow
    {
        public abstract bool CanWindowOpen();
        public abstract bool IsWindowFrosted();
        public abstract EWindowType GetWindowType();
        
    }
}