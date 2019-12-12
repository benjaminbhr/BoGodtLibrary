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
            IMasterWindow bathroomwindow = new SmallWindow();
            IMasterDoor bathroomdoor = new RoomDoor();
            bathroomwindow.windowFrosted = false;
            bathroomwindow.windowOpen = false;
            windows.Add(bathroomwindow);
            doors.Add(bathroomdoor);
        }

        public int maxwindows = 1;
        public void AddWindows(EWindowType windowType)
        {

            switch (windowType)
            {
                case EWindowType.Small:
                    if (windows.Count() == 1)
                    {
                        throw new OnlyOneWindowException(string.Format("This room can only contain 1 window"));
                    }
                    else
                    {
                        IMasterWindow smallwindow = new SmallWindow();
                        windows.Add(smallwindow);
                    }
                    break;
                case EWindowType.Medium:
                    if (windows.Count() == 1)
                    {
                        throw new OnlyOneWindowException(string.Format("This room can only contain 1 window"));
                    }
                    else
                    {
                        IMasterWindow mediumwindow = new MediumWindow();
                        windows.Add(mediumwindow);
                    }
                    break;
                case EWindowType.Large:
                    if (windows.Count() == 1)
                    {
                        throw new OnlyOneWindowException(string.Format("This room can only contain 1 window"));
                    }
                    else
                    {
                        IMasterWindow largewindow = new LargeWindow();
                        windows.Add(largewindow);
                    }
                    break;
                case EWindowType.Nowindow:
                    break;
                default:
                    break;
            }
        }
    }
}
