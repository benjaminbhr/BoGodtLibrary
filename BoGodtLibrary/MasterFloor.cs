using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class MasterFloor : IMasterFloor
    {
        private EFloorType floorType = EFloorType.Click;
        public EFloorType SetFloorType 
        {
            get => floorType;
            set => floorType = value;
        }

        private EColor floorColor = EColor.ColorWhite;
        public EColor SetFloorColor
        {
            get => floorColor;
            set => SetFloorColor = value;
        }
    }
}
