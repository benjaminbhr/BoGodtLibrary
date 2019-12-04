using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class MediumWindow : MasterWindow
    {
        public bool windowopen { get; set; }
        public override void CanWindowOpen(bool canwindowopen)
        {
            this.windowopen = canwindowopen;
        }

        public override EColor GetColor()
        {
            throw new NotImplementedException();
        }

        public override EWindowMaterial GetWindowMaterial()
        {
            throw new NotImplementedException();
        }

        public override EWindowType GetWindowType()
        {
            return EWindowType.Medium;
        }

        public override bool IsWindowFrosted()
        {
            return false;
        }
    }
}
