using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.FastAndSlowPointer;

public static class HappyNumberProblem
{
    public static bool HappyNumber(int num)
    {
        int slow = num;
        int fast = num;

        while (true)
        {
            slow = GetNextNum(slow);
            fast = GetNextNum(GetNextNum(fast));

            if (slow == 1)
            {
                return true;
            }

            if (slow == fast)
            {
                return false;
            }
        }
    }

    public static int GetNextNum(int num)
    {
        var nextNum = 0;
        while (num > 0)
        {
            var lastDigit = num % 10;
            nextNum += lastDigit * lastDigit;
            num /= 10;
        }

        return nextNum;
    }
}
