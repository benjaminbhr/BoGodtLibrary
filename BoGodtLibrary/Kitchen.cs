using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{

    
    public class Kitchen : MasterRoom, IKitchen
    {

        public int doorcount
        {
            get => doors.Count;
        }


        public override ERoomType GetRoomType()
        {
            return ERoomType.Kitchen;
        }
        public bool IsNew()
        {
            return true;
        }
        public override void AddWindows(IMasterWindow window)
        {
            if (MaxWindows >= 1)
            {
                throw new Exception("Too many windows :(");
            }
            else
            {
                windows.Add(new SmallWindow());
                MaxWindows++;
            }
        }

        
        public override void AddDoors(IMasterDoor door)
        {
            throw new NotImplementedException();
        }

        int MaxWindows = 0;

        public override void AddFloor(IMasterFloor floor)
        {
            floor.SetFloorType = EFloorType.Linoleum;
            this.floors.Add(floor);
        }


    }
}
