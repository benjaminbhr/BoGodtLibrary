using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public interface IBathroom
    {
        List<IMasterWindow> GetWindows();
    }
}
