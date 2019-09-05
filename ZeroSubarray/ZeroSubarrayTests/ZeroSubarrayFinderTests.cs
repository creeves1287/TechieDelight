using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZeroSubarray;

namespace ZeroSubarrayTests
{
    [TestClass]
    public class ZeroSubarrayFinderTests
    {
        [TestMethod]
        public void ZeroSubarrayFinderTest()
        {
            IZeroSubarrayFinder zeroSubarrayFinder = new ZeroSubarrayFinder();
            RunTests(zeroSubarrayFinder);
        }

        [TestMethod]
        public void ZeroSubarrayFinderWithHashingTest()
        {
            IZeroSubarrayFinder zeroSubarrayFinder = new ZeroSubarrayFinderWithHashing();
            RunTests(zeroSubarrayFinder);
        }

        private void RunTests(IZeroSubarrayFinder zeroSubarrayFinder)
        {
            IsTrueTest(zeroSubarrayFinder);
            IsFalseTest(zeroSubarrayFinder);
        }

        private void IsTrueTest(IZeroSubarrayFinder zeroSubarrayFinder)
        {
            int[] arr = new int[] { 3, 4, -7, 3, 1, 3, 1, -4, -2, -2 };
            bool result = zeroSubarrayFinder.ZeroSubarrayExists(arr);
            Assert.IsTrue(result);
        }

        private void IsFalseTest(IZeroSubarrayFinder zeroSubarrayFinder)
        {
            int[] arr = new int[] { 3, 4, 7, 3, 1, 3, 1, 4, 2, 2 };
            bool result = zeroSubarrayFinder.ZeroSubarrayExists(arr);
            Assert.IsFalse(result);
        }

    }
}
