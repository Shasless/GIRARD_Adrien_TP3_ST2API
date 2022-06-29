using System;
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
            Assert.AreEqual(p.objectRes.name,"Palais-Royal","Error Api City");
            Assert.AreNotEqual(p.objectRes.name,"gggg","Error Api City");

        }
        
        [TestMethod]
        public void testCity2()
        {
            var p = new APIcontrol();
            p.GetCity("59.9138688","10.7522454");
            Assert.AreEqual(p.objectRes.name,"Oslo","Error Api City");
            Assert.AreNotEqual(p.objectRes.name,"Paris","Error Api City");

        }
        [TestMethod]
        public void testCity3()
        {
            var p = new APIcontrol();
            p.GetInfo2("Paris");
            Assert.AreEqual(p.objectRes.name,"Paris","Error Api City");
            Assert.AreNotEqual(p.objectRes.name,"Prague","Error Api City");

        }
        
        [TestMethod]
        public void testForecast()
        {
            var p = new APIcontrol();
            p.GetInfo2("Paris");
            Assert.AreNotEqual(p.objectRes2.list[8].dt,p.objectRes2.list[16].dt,"Error Api City");

        }
        [TestMethod]
        public void testForecast2()
        {
            var p = new APIcontrol();
            p.GetInfo2("cetteVillen'existepas");
            Assert.AreEqual(p.objectRes.name,"Paris","Error Api City");

        }
    }
}