using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoGodtLibrary;

namespace BoGodtLibrary.BoGodtExceptions
{
    class OnlyOneWindowException : Exception
    {
        public OnlyOneWindowException(string message) 
            :base(message)
        {

        }
        
    }
}