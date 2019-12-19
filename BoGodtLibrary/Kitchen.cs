using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{

    
    public class Kitchen : MasterRoom, IKitchen
    {

     
        public override ERoomType GetRoomType()
        {
            return ERoomType.Kitchen;
        }
        public bool IsNew()
        {
            return true;
        }

        private const int MAX_WINDOWS = 3;
        public override void AddWindows(IMasterWindow window)
        {
            
            if (windows.Count + 1 > MAX_WINDOWS)
            {
                throw new BoGodtExceptions.MaxThreeWindowsException();
            }
            else
            {
                windows.Add(new SmallWindow());               
            }
        }

        
        public override void AddDoors(IMasterDoor door)
        {
            throw new NotImplementedException();
        }

      

        public override void AddFloor(IMasterFloor floor)
        {
            floor.FloorType = EFloorType.Linoleum;
            this.floors.Add(floor);
        }


    }
}
