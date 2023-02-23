
namespace Algorithm786.Tests
{
    public class Node
    {
        public int value;
        public Node Next { get; set; }
        public Node(int value)
        {
            this.value = value;
        }

    }

    public class ListNode
    {
        int value;
        public Node Head { get; private set; }
        public Node Tail { get; private set; }

        public void Add(int value)
        {
            if (Head == null)
            {
                Head = new Node(value);
                Tail = Head;
                return;
            }
            var node = new Node(value);
            Tail.Next = node;
            Tail = node;
        }
        public void AddCycle(Node headCycle, int val)
        {
            if (Head == null)
            {
                return;
            }
            var node = new Node(val);
            Tail.Next = node;
            Tail = node;
            node.Next = headCycle;


        }

        public Node GetNode(int val)
        {
            if (Head == null)
                return null;
            var current = Head;
            while (current != null)
            {
                if (current.value == val)
                    return current;
                current = current.Next;
            }
            return null;
        }


    }

    public class HasCycleLinkedList
    {
        public bool HasCycle(Node head)
        {
            if (head == null) return false;
            var cur = head;
            var cur2 = head.Next;
            while (cur != null)
            {
                while (cur2 != null)
                {
                    if (cur == cur2)
                    { return true; }
                    cur2 = cur2.Next;
                }
                cur = cur.Next;
            }
            return false;
        }
    }
}
