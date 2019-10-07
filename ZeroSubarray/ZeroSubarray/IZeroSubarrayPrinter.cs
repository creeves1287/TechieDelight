using System.Collections.Generic;

namespace ZeroSubarray
{
    public interface IZeroSubarrayPrinter
    {
        IList<IList<int>> PrintZeroSubarrays(int[] arr);
    }
}