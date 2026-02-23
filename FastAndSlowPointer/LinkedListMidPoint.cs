using DataStructureAndAlgorithms.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.FastAndSlowPointer;

public sealed class LinkedListMidPoint
{
    public static Node<T> MidPoint<T>(Node<T> head)
    {
        ArgumentNullException.ThrowIfNull(head, nameof(head));

        var slow = head;
        var fast = head;

        while(fast is not null && fast.Next is not null)
        {
            fast = fast.Next.Next;
            slow = slow.Next;
        }

        return slow;
    }
}
