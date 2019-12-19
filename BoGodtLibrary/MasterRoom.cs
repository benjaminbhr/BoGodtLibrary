using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public abstract class MasterRoom : IMasterRoom
    {
        public abstract void AddWindows(IMasterWindow window);
        public abstract void AddDoors(IMasterDoor door);
        public abstract void AddFloor(IMasterFloor floor);
        public abstract ERoomType GetRoomType();

        protected List<IMasterWindow> windows = new List<IMasterWindow>();
        public List<IMasterWindow> GetWindows()
        {
            return windows;
        }
        protected List<IMasterDoor> doors = new List<IMasterDoor>();
        public List<IMasterDoor> GetDoors()
        {
            return doors;
        }
        protected List<IMasterFloor> floors = new List<IMasterFloor>();
        public List<IMasterFloor> GetFloorType()
        {
            return floors;
        }

        
    }
}