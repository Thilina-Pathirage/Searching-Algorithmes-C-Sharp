using System;
using System.Collections.Generic;
using System.Text;

namespace binarySearchAlgo
{
    class binarySearch
    {
        public int binarySearchmethod(int[] items, int sk, int low, int high)
        {
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (items[mid] == sk)
                    return mid;

                if (items[mid] < sk)
                    low = mid + 1;

                else
                    high = mid - 1;
            }

            return -1;
        }
    }
}
