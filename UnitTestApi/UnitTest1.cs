using ApiControler;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestApi
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void testCity()
        {
            var p = new APIcontrol();
            p.GetCity("48.864716","2.349014");
            Assert.AreEqual(p.objectRes.name,"Paris","Error Api City");
            Assert.AreNotEqual(p.objectRes.name,"gggg","Error Api City");

        }
    }
}