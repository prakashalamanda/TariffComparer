using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TariffComparer;
using TariffComparer.Builder;

namespace TariifComparerTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestBasicEngine()
        {
            Assert.AreEqual(830, RunBasicEngineTest(3500));
            Assert.AreEqual(1050, RunBasicEngineTest(4500));
            Assert.AreEqual(1380, RunBasicEngineTest(6000));
        }

        [TestMethod]
        public void TestPackagedEngine()
        {
            Assert.AreEqual(800, RunPackagedEngineTest(3500));
            Assert.AreEqual(950, RunPackagedEngineTest(4500));
            Assert.AreEqual(1400, RunPackagedEngineTest(6000));
        }

        private double RunBasicEngineTest(int consumption)
        {
            var x = Program.RunEngine(consumption, new BasicEngine(), new BasicBuilder());

            return x.AnnualCost;
        }

        private double RunPackagedEngineTest(int consumption)
        {
            var x = Program.RunEngine(consumption, new PackagedEngine(), new PackagedBuilder());

            return x.AnnualCost;
        }
    }
}
