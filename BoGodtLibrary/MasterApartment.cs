using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class MasterApartment
    {

        IMasterDoor door
        {
            get => door;
            set => door = value;
        }
        IBathroom bathroom
        {
            get => bathroom;
            set => bathroom = value;
        }
        IMasterWindow window
        {
            get => window;
            set => window = value;
        }

        protected MasterApartment(IMasterDoor d, IBathroom k, IMasterWindow w)
        {
            this.door = d;
            this.bathroom = k;
            this.window = w;
        }

    }
}
