using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public class Floor : IFloor
    {
        private EFloorType _floorType = EFloorType.Click;
        public EFloorType floorType
        {
            get => _floorType;
            set => _floorType = value;
        }

        private EColor _color = EColor.ColorWhite;
        public EColor color
        {
            get => _color;
            set => _color = value;
        }
    }
}
