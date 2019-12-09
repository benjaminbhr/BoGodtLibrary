using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class Bathroom : MasterRoom
    {
        public override ERoomType GetRoomType()
        {
            return ERoomType.Bathroom;
        }
        public bool IsNew()
        {
            return true;
        }

        public Bathroom()
        {
            IMasterWindow bathroomwindow = new SmallWindow();
            bathroomwindow.windowFrosted = false;
            bathroomwindow.windowOpen = false;
            windows.Add(bathroomwindow);
        }

        
    }
}
