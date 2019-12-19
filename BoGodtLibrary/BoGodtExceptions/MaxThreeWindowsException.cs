using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary.BoGodtExceptions
{
    public class MaxThreeWindowsException : Exception
    {
        private const string MAXTHREEWINDOWS = "Too many windows were added ";
        public MaxThreeWindowsException()
            : base(MAXTHREEWINDOWS)
        {

        }
    }
}
