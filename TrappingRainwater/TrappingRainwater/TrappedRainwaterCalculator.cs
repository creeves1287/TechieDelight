using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrappingRainwater
{
    public class TrappedRainwaterCalculator : ITrappedRainwaterCalculator
    {
        public int CalculateRainwater(int[] heights)
        {
            if (heights == null)
                throw new ArgumentNullException("heights");

            if (heights.Length == 0) return 0;

            int left = 0, right = heights.Length - 1;
            int maxLeft = heights[left], maxRight = heights[right];
            int water = 0;

            while (left < right)
            {
                if (heights[left] <= heights[right])
                {
                    left++;
                    maxLeft = Math.Max(maxLeft, heights[left]);
                    water += maxLeft - heights[left];
                }
                else
                {
                    right--;
                    maxRight = Math.Max(maxRight, heights[right]);
                    water += maxRight - heights[right];
                }
            }

            return water;
        }
    }
}
