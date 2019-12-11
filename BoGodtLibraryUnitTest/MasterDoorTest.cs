using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoGodtLibrary;

namespace BoGodtLibraryUnitTest
{
    [TestClass]
    public class MasterDoorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            FrontDoor fd = new FrontDoor();

            Assert.IsTrue(fd.SetDoorOpen == true);
        }
    }
}
