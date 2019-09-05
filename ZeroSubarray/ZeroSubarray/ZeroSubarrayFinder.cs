using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroSubarray
{
    public class ZeroSubarrayFinder : IZeroSubarrayFinder
    {
        public bool ZeroSubarrayExists(int[] arr)
        {
            if (arr == null)
                throw new ArgumentNullException("arr");
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                int currentSum = sum;
                if (currentSum == 0)
                    return true;
                for (int j = 0; j < i; j++)
                {
                    currentSum -= arr[j];
                    if (currentSum == 0)
                        return true;
                }
            }
            return false;
        }
    }
}
