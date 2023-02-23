using System;

namespace Algorithm786
{
    public class Node
    {
        public int Index { get; set; }
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node(int value, int index)
        {
            Value = value;
            Index = index;
        }
    }

    public class StackImplimantWithHeap
    {
        public Node Root { get; private set; }
        public int Count { get; private set; }

        public void Push(int value)
        {
            if (Root == null)
            {
                var index = ++Count;
                Root = new Node(value, Count);
                return;
            }
            int _index = ++Count;
            var _newNode = new Node(value,_index);
            Push(Root, _newNode);
        }

        private void Push(Node root ,Node node)
        {
            if (node.Value <= root.Value)
            {
                if (root.Left == null)
                {
                    root.Left = node;
                    return;
                }
                else
                    Push(root.Left, node);
            }
            if (node.Value > root.Value )
            {
                if (root.Right == null)
                {
                    root.Right = node;
                    return;
                }
                else
                    Push(root.Right, node);
            }
        }


        public Node Pop() 
        {
            if (Root == null)
            {
                return null;
            }
            if (Count == 1)
            {
                var node = Root;
                Root = null;
                --Count;
                return node;
            }
            return Pop(Root);
        }
        private Node Pop(Node root)
        {
            var prev = root;
            var currLeft = root.Left;
            var currRight = root.Right;


            if (currLeft != null)
            {
                if (currLeft.Index == Count
                && currLeft.Left == null
                && currLeft.Right == null)
                {
                    var node = currLeft;
                    prev.Left = null;
                    --Count;
                    return node;
                }
                else
                    Pop(prev.Left);
            }

            if (currRight != null)
            {
                if (root.Right.Index == Count
                && root.Right.Left == null
                && root.Right.Right == null)
                {
                    var node = currRight;
                    prev.Right = null;
                    --Count;
                    return node;
                }
                else
                    Pop(prev.Right);
            }
            return null;
        }

        private Node Pop1(Node root)
        {
            if (root != null)
            {
                if (root.Index == Count
                && root.Left == null
                && root.Right == null)
                {
                    var node = root;
                    root = null;
                    --Count;
                    return node;
                }
                Pop1(root.Left);
                Pop1(root.Right);
            }
            return null;
        }

        public List<int> PreOrder()
        {
            if (Root == null)
                return new List<int>();
            return PreOrder(Root);
        }

        private List<int> PreOrder(Node startNode)
        {
            var list = new List<int>();
            if (startNode != null)
            {
                list.Add(startNode.Value);
                if (startNode.Left != null)
                {
                    list.AddRange(PreOrder(startNode.Left));
                }
                if (startNode.Right != null)
                {
                    list.AddRange(PreOrder(startNode.Right));
                }
            }
            return list;
        }
    }
}
