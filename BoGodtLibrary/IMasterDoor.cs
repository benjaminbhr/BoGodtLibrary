using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public interface IMasterDoor
    {
        EDoorType GetDoorType();
        EDoorMaterial GetDoorMaterial();
        EColor GetColor();
        bool IsLockable();
    }
}
