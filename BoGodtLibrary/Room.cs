using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoGodtLibrary.BoGodtExceptions;

namespace BoGodtLibrary
{
    public class Room : MasterRoom
    {
        private const int MAX_WINDOWS = 5;
        public override ERoomType GetRoomType()
        {
            return ERoomType.Room;
        }

        public Room(IMasterWindow window, IMasterDoor door, IMasterFloor floor)
            : base()
        {
            this.windows.Add(window);
            this.doors.Add(door);
            this.floors.Add(floor);
        }

        public override void AddWindows(IMasterWindow roomwindow) 
        {
            
            if (windows.Count + 1 > MAX_WINDOWS)
            {
                throw new BoGodtExceptions.OnlyFiveWindowsException();
            }
            
            Console.WriteLine("windows.Count: " + (windows.Count));
            roomwindow.windowFrosted = false;
            roomwindow.windowOpen = true;
            windows.Add(roomwindow);
            Console.WriteLine("New window were added to the room!");
        }

        public override void AddDoors(IMasterDoor door)
        {
            throw new NotImplementedException();
        }

    }
}