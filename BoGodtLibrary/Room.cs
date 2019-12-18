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
        private const int MIN_WINDOWS = 1;
        public override ERoomType GetRoomType()
        {
            return ERoomType.Room;
        }

        public Room() 
        {
            if (windows.Count + 1 < MIN_WINDOWS)
            {
                throw new BoGodtExceptions.MinimumOneWindowException();
            }

            IMasterWindow roomwindow = new SmallWindow();
            roomwindow.windowFrosted = false;
            roomwindow.windowOpen = true;
            windows.Add(roomwindow);
            Console.WriteLine("New window were added to the room!");
        }

        public void addWindow(IMasterWindow roomwindow) 
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
    }
}