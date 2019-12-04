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
            return ERoomType.Kitchen;
        }
        public override bool IsNew()
        {
            return true;
        }
        public List<IMasterWindow> windows = new List<IMasterWindow>();
    }
}
