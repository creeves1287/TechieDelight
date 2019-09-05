using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroSubarray
{
    public class ZeroSubarrayFinderWithHashing : IZeroSubarrayFinder
    {
        public bool ZeroSubarrayExists(int[] arr)
        {
            if (arr == null || arr.Length == 0) return false;
            HashSet<int> sums = new HashSet<int>();
            sums.Add(0);
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (sums.Contains(sum))
                    return true;
                sums.Add(sum);
            }
            return false;
        }
    }
}
