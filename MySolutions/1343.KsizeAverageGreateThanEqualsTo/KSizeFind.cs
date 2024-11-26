using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySolutions._1343.KsizeAverageGreateThanEqualsTo
{
    internal class KSizeFind
    {
        public static void main()
        {
            int[] arr = { 2, 2, 2, 2, 5, 5, 5, 8 };
            int k = 3, threashold = 4;

            KSizeFind kSizeFind = new KSizeFind();
            kSizeFind.NumOfSubArray(arr, k, threashold);
        }

        internal int NumOfSubArray(int[] arr, int k, int threadshold)
        {
            int count = 0;
            int windowSum = 0;
            int target = k * threadshold;

            for(int i=0; i<k; i++)
            {
                windowSum += arr[i];
            }

            if (windowSum >= target) count++;

            for(int i = k; i<arr.Length; i++)
            {
                windowSum = windowSum + (arr[i] - arr[i - k]);
                if (windowSum >= target) count++;
            }

            return count;
        }
    }
}
