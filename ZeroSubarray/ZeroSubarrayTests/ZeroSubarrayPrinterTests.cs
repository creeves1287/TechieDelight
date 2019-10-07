using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZeroSubarray;
using System.Diagnostics;

namespace ZeroSubarrayTests
{
    /// <summary>
    /// Summary description for ZeroSubarrayPrinterTests
    /// </summary>
    [TestClass]
    public class ZeroSubarrayPrinterTests
    {
        [TestMethod]
        public void ZeroSubarrayPrinterTest()
        {
            IZeroSubarrayPrinter zeroSubarrayPrinter = new ZeroSubarrayPrinter();
            RunTests(zeroSubarrayPrinter);
        }

        private void RunTests(IZeroSubarrayPrinter zeroSubarrayPrinter)
        {
            int[] arr = new int[] { 3, 4, -7, 3, 1, 3, 1, -4, -2, -2 };
            IList<IList<int>> result = zeroSubarrayPrinter.PrintZeroSubarrays(arr);
            PrintResults(result);
        }

        private void PrintResults(IList<IList<int>> result)
        {
            StringBuilder output = new StringBuilder();
            foreach (IList<int> subarray in result)
            {
                output.Append('[');
                for (int i = 0; i < subarray.Count; i++)
                {
                    int item = subarray[i];
                    output.Append(item);
                    if (i < subarray.Count - 1)
                    {
                        output.Append(',');
                    }

                }
                output.Append(']');
                output.Append('\n');
            }
            output.Append($"Total Count: { result.Count }");
            Trace.WriteLine(output.ToString());
        }
    }
}
