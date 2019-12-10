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

        public EColor GetColor()
        {
            throw new NotImplementedException();
        }
    }
}
