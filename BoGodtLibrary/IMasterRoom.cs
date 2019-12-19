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
        void AddDoors(IMasterDoor door);
        void AddFloor(IMasterFloor floor);
        ERoomType GetRoomType();
        List<IMasterWindow> GetWindows();
        List<IMasterFloor> GetFloor();
        List<IMasterDoor> GetDoors();
    }
}
