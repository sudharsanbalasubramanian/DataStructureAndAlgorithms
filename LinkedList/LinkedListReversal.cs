using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.LinkedList;

public static class LinkedListReversal
{
    public static Node<T> Reverse<T>(Node<T> head)
    {
        Node<T> prevNode = null;
        Node<T> curNode = head;

        while (curNode != null)
        {
            Node<T> nextNode = curNode.Next;
            curNode.Next = prevNode;
            prevNode = curNode;
            curNode = nextNode;
        }

        return prevNode;
    }
}
