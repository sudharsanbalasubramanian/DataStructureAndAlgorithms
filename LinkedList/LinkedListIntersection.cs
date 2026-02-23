using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.LinkedList;

public static class LinkedListIntersection
{
    public static Node<T> GetIntersectionNode<T>(Node<T> headA, Node<T> headB)
    {
        if (headA == null || headB == null)
        {
            throw new ArgumentNullException();
        }

        Node<T> p1 = headA;
        Node<T> p2 = headB;

        while (p1 != p2)
        {
            p1 = p1 != null ? p1.Next : headB;
            p2 = p2 != null ? p2.Next : headA;
        }

        return p1;
    }
}
