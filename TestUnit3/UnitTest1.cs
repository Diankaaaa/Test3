using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Test3;

namespace TestUnit3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Airo auto = new Airo("Аэромобиль");
            Pyatna pyatno = new Pyatna("пятна");

            Assert.AreEqual("Аэромобиль", auto.name);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Airo auto = new Airo("Аэромобиль");
            Assert.AreEqual(", со скоростью, превышающей R17, вынес их по стальному туннелю на хмурую поверхность Магратеи, объятую мглистыми предрассветными сумерками.", auto.heightSpeed());
        }

        [TestMethod]
        public void TestMethod3()
        {
            Pyatna pyatno = new Pyatna("пятна");
            Assert.AreEqual(pyatno.name, "пятна");
        }

        [TestMethod]
        public void TestMethod4()
        {
            Pyatna pyatno = new Pyatna("пятна");
            Assert.AreEqual(pyatno.prostupat(), "Сквозь тьму уже проступали пятна призрачного серого света.");
        }
    }
}
