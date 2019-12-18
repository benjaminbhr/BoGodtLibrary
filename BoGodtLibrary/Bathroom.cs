using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoGodtLibrary.BoGodtExceptions;

namespace BoGodtLibrary
{
    public class Bathroom : MasterRoom
    {

        private const int MAX_WINDOWS = 1;
        public IMasterWindow smallwindow = new SmallWindow();
        public override ERoomType GetRoomType()
        {
            return ERoomType.Bathroom;
        }


        public Bathroom()
        {
        }

        public void AddWindow(IMasterWindow bathRoomWindow)
        {

            if (windows.Count + 1 > MAX_WINDOWS)
            {
                throw new BoGodtExceptions.OnlyOneWindowsException();
            }
            bathRoomWindow.windowFrosted = false;
            bathRoomWindow.windowOpen = true;
            windows.Add(bathRoomWindow);
            Console.WriteLine("windows.count: " + (windows.Count));
            Console.WriteLine("New window were added to the room!");
        }
    }
}
