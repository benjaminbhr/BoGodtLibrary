using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class Room : MasterRoom
    {
        public override ERoomType GetRoomType()
        {
            return ERoomType.Room;
        }
        
        public Room()
        {
        int presentWindows = 0;
        int maxWindows = 5;
        int minWindows = 1;

            if (presentWindows <= minWindows)
            {
                IMasterWindow roomwindow = new SmallWindow();
                roomwindow.windowFrosted = false;
                roomwindow.windowOpen = true;
                windows.Add(roomwindow);
                presentWindows++;
                Console.WriteLine("New window were added to room since none were present!");
            }
            
            else if (presentWindows > maxWindows)
            {
                throw new System.InvalidOperationException("You can't add more than five windows to a room!");
            }

        }
    }
}