using BoGodtLibrary.BoGodtExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BoGodtLibrary
{
    public class LivingRoom : MasterRoom
    {
        public override void AddWindows(IMasterWindow window)
        {
            throw new NotImplementedException();
        }

        public override void AddDoors(IMasterDoor door)
        {
            throw new NotImplementedException();
        }

        public override void AddFloor(IMasterFloor floor)
        {
            throw new NotImplementedException();
        }

        public override ERoomType GetRoomType()
        {
            return ERoomType.LivingRoom;
        }




    }
}
