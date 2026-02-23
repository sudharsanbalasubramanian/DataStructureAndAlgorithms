using DataStructureAndAlgorithms.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.FastAndSlowPointer;

public sealed class LinkedListLoop
{
    public static bool IsLoop<T>(Node<T> head)
    {
        if (head is null)
        {
            return false;
        }

        var slow = head;
        var fast = head;

        while (fast is not null && fast.Next is not null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;

            if (slow == fast)
            {
                return true;
            }
        }

        return false;
    }
}
