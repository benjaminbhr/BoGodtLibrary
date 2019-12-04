using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    class Entrance:MasterRoom, IEntrance
    {
        public override ERoomType GetRoomType()
        {
            return ERoomType.Entrance;
        }

        //Do we need this? And the interface at all?
        public void MyMethod(ERoomType Entrance)
        {
            throw new NotImplementedException();
        }
    }
}
