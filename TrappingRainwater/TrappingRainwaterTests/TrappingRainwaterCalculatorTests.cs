using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrappingRainwater;

namespace TrappingRainwaterTests
{
    [TestClass]
    public class TrappingRainwaterCalculatorTests
    {
        [TestMethod]
        public void TrappingRainwaterCalculator()
        {
            ITrappedRainwaterCalculator trappedRainwaterCalculator = new TrappedRainwaterCalculator();
            RunTests(trappedRainwaterCalculator);
        }

        private void RunTests(ITrappedRainwaterCalculator trappedRainwaterCalculator)
        {
            int[] heights = new int[] { 6, 3, 4, 8, 5, 7, 2 };
            int expected = 7;
            int result = trappedRainwaterCalculator.CalculateRainwater(heights);
            Assert.AreEqual(expected, result);
        }
    }
}
