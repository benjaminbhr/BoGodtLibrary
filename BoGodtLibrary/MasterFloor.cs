using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class MasterFloor : IMasterFloor
    {
        private EFloorType _FloorType = EFloorType.Click;
        public EFloorType FloorType 
        {
            get => _FloorType;
            set => _FloorType = value;
        }

        private EColor _FloorColor = EColor.ColorWhite;
        public EColor FloorColor
        {
            get => _FloorColor;
            set => _FloorColor = value;
        }
    }
}
