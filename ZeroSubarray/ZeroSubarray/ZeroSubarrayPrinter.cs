using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroSubarray
{
    public class ZeroSubarrayPrinter : IZeroSubarrayPrinter
    {
        public IList<IList<int>> PrintZeroSubarrays(int[] arr)
        {
            if (arr == null) return null;
            IList<IList<int>> result = new List<IList<int>>();
            Dictionary<int, IList<int>> map = new Dictionary<int, IList<int>>();
            map.Add(0, new List<int>());
            map[0].Add(-1);
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (map.ContainsKey(sum))
                {
                    IList<int> indexes = map[sum];
                    foreach(int start in indexes)
                    {
                        IList<int> sub = GetSubarray(arr, start + 1, i);
                        result.Add(sub);
                    }
                }
                else
                {
                    map.Add(sum, new List<int>());
                }
                map[sum].Add(i);
            }
            return result;
        }

        private IList<int> GetSubarray(int[] arr, int start, int end)
        {
            IList<int> sub = arr.Skip(start).Take(end - start + 1).ToList();
            return sub;
        }
    }
}
