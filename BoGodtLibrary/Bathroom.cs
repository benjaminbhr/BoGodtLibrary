using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public void AddWindows(EWindowType windowType)
        {
            switch (windowType)
            {
                case EWindowType.Small:
                    IMasterWindow smallwindow = new SmallWindow();
                    windows.Add(smallwindow);
                    break;
                case EWindowType.Medium:
                    IMasterWindow mediumwindow = new MediumWindow();
                    windows.Add(mediumwindow);
                    break;
                case EWindowType.Large:
                    IMasterWindow largewindow = new LargeWindow();
                    windows.Add(largewindow);
                    break;
                case EWindowType.Nowindow:
                    break;
                default:
                    break;
            }
        }
    }
}
