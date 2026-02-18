using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.HashMapAndSet;

public static class PairSumUnSorted
{
    public static int[] TwoSum(int[] arr, int target)
    {
        Dictionary<int, int> map = [];

        for (int i = 0; i < arr.Length; i++)
        {
            int needed = target - arr[i];

            if (map.ContainsKey(needed))
            {
                return [needed, arr[i]];
            }

            map[arr[i]] = i;
        }

        return [];
    }
}
