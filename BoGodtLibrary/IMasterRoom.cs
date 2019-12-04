using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public interface IMasterRoom
    {
        ERoomType GetRoomType();
        List<IMasterWindow> GetWindows();
        List<IFloor> GetFloorType();
    }
}
