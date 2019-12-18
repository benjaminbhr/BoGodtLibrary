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

        public Room() { }

        public void addWindow(IMasterWindow roomwindow) 
        {
            
            if (windows.Count +1 > MAX_WINDOWS)
            {
                throw new BoGodtExceptions.OnlyFiveWindowsException();
            }
            Console.WriteLine("windows.count: " + (windows.Count + 1));
            roomwindow.windowFrosted = false;
            roomwindow.windowOpen = true;
            windows.Add(roomwindow);
            Console.WriteLine("New window were added to the room!");
        }
    }
}