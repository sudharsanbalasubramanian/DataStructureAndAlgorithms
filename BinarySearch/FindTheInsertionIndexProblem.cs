using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.BinarySearch;

public static class FindTheInsertionIndexProblem
{
    public static int FindTheInsertionIndex(List<int> list, int target)
    {
        int left = 0;
        int right = list.Count;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (list[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        return left;
    }
}
