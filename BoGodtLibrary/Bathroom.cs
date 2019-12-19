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
        public int windowCount
        {
            get => windows.Count();
        }
        public override ERoomType GetRoomType()
        {
            return ERoomType.Bathroom;
        }

        public Bathroom()
        {
            IMasterWindow window = new SmallWindow();
            window.windowCasement = EWindowCasement.CasementOne;
            window.windowFrosted = true;
            window.windowOpen = false;
            windows.Add(window);

        }

        public override void AddWindows(IMasterWindow window)
        {
            throw new BoGodtExceptions.OnlyOneWindowsException();
        }

    }
}
