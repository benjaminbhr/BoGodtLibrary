using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class Studio : MasterApartment
    {
        public Studio(IMasterDoor d, IBathroom   k, IMasterWindow w)
            :base(d,k,w)
        {
            MasterApartment studioapart = new Studio(new RoomDoor(), new Bathroom(), new SmallWindow());
        }
    }
}
