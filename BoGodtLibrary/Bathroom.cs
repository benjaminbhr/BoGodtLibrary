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
        public IMasterWindow smallwindow = new SmallWindow();
        public override ERoomType GetRoomType()
        {
            return ERoomType.Bathroom;
        }


        public Bathroom()
        {
            int presentWindows = 0;
            int maxWindows = 1;
            int minWindows = 1;

            if (presentWindows < minWindows)
            {
                IMasterWindow bathRoomWindow = new SmallWindow();
                bathRoomWindow.windowFrosted = false;
                bathRoomWindow.windowOpen = true;
                windows.Add(bathRoomWindow);
                presentWindows++;
                Console.WriteLine("New window were added to room since none were present!");
            }

            else if (presentWindows == maxWindows)
            {
                throw new System.InvalidOperationException("You can't add more than five windows to a room!");
            }
            void AddWindows(EWindowType windowType)
            {
                switch (windowType)
                {
                    case EWindowType.Small:
                        IMasterWindow smallwindow = new SmallWindow();

                        break;
                    case EWindowType.Medium:
                        break;
                    case EWindowType.Large:
                        break;
                    case EWindowType.Nowindow:
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
