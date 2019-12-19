using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public interface IMasterRoom
    {
        void AddWindows(IMasterWindow window);
        void AddDoors();
        ERoomType GetRoomType();
        List<IMasterWindow> GetWindows();
        List<IMasterFloor> GetFloorType();
    }
}
