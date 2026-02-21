namespace DataStructureAndAlgorithms.LinkedList;

public static class RemoveKthNode
{
    public static Node<T> RemoveKthFromEnd<T>(Node<T> head, int k)
    {
        if (head == null || k <= 0)
        {
            return head;
        }

        var dummy = new Node<T> { Next = head };

        var leader = dummy;
        var follower = dummy;

        // Move leader k+1 steps
        for (int i = 0; i <= k; i++)
        {
            if (leader == null)
            {
                return head; // k > length
            }

            leader = leader.Next;
        }

        while (leader != null)
        {
            leader = leader.Next;
            follower = follower.Next;
        }

        if (follower.Next != null)
        {
            follower.Next = follower.Next.Next;
        }

        return dummy.Next;
    }
}
