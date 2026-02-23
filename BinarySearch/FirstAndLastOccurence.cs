using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.BinarySearch;

public sealed class FirstAndLastOccurence
{
    public int[] SearchRange(int[] arr, int target)
    {

        var first = FirstOccurrence(arr, target);

        if (first == -1)
        {
            return [-1, -1];
        }

        var last = LastOccurrence(arr, target);

        return [first, last];
    }
    public static int FirstOccurrence(int[] numbers, int val)
    {
        int low = 0;

        int high = numbers.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (numbers[mid] > val)
            {
                high = mid - 1;
            }
            else if (numbers[mid] < val)
            {
                low = mid + 1;
            }
            else
            {
                if (mid == 0 || numbers[mid - 1] != numbers[mid])
                {
                    return mid;
                }
                else
                {
                    high = mid - 1;
                }
            }
        }

        return -1;
    }

    public static int LastOccurrence(int[] numbers, int val)
    {
        int low = 0;
        int high = numbers.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (numbers[mid] == val)
            {
                if (mid == numbers.Length - 1 || numbers[mid + 1] != numbers[mid])
                {
                    return mid;
                }
                else
                {
                    low = mid + 1; // Continue searching right
                }
            }
            else if (numbers[mid] > val)
            {
                high = mid - 1; // Move left ✅
            }
            else
            {
                low = mid + 1; // Move right ✅
            }
        }

        return -1; // Better than default
    }
}
