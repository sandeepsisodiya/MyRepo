using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.BinarySearchTree
{
    class BinarySearchTreeNode<TNode> : IComparable<TNode> where TNode : IComparable<TNode>
    {
        public BinarySearchTreeNode(TNode value)
        {
            Value = value;
        }
        public TNode Value { get; private set; }

        public BinarySearchTreeNode<TNode> Left { get; set; }
        public BinarySearchTreeNode<TNode> Right { get; set; }

        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other);
        }
    }

    /*
    class BinarySearchTree<T>
    {
        public delegate void Print(BinarySearchTreeNode<T> node);

        Print printvalue = PrintValue;

        private BinarySearchTreeNode<T> _root;
        private int _count;

        public void Add(T Value)
        {
            if (_root == null)
            {
                _root = new BinarySearchTreeNode<T>(Value);
            }
            else
            {
                AddTo(_root, Value);
            }
            _count++;
        }

        private void AddTo(BinarySearchTreeNode<T> node, T value)
        {
            if (value < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new BinarySearchTreeNode<T>(value);
                }
                else
                {
                    AddTo(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new BinarySearchTreeNode<T>(value);
                }
                else
                {
                    AddTo(node.Right, value);
                }
            }
        }

        public bool Contains(T value)
        {
            BinarySearchTreeNode<T> parent;
            return FindWithParent(value, out parent) != null;
        }

        private BinarySearchTreeNode<T> FindWithParent(T value, out BinarySearchTreeNode<T> parent)
        {
            BinarySearchTreeNode<T> current = _root;
            parent = null;

            while (current != null)
            {
                int result = current.CompareTo(value);

                if (result > 0)
                {
                    parent = current;
                    current = current.Left;
                }
                else if (result < 0)
                {
                    parent = current;
                    current = current.Right;
                }
                else
                {
                    break;
                }
            }

            return current;
        }


        public void InOrder(BinarySearchTreeNode<T> node)
        {

            InOrder(node.Left);
            printvalue(node);
            InOrder(node.Right);
        }

        public IEnumerator<T> InOrderTraversal(BinarySearchTreeNode<T> node)
        {
            yield return node.Value;

        }

        public IEnumerator<T> InOrderTraversal()
        {
            BinarySearchTreeNode<T> current = _root;
            return InOrderTraversal(current);
        }

         IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return InOrderTraversal();
        }

        public static void PrintValue(BinarySearchTreeNode<T> node)
        {
            Console.WriteLine(node.Value);
        }
    }
    */
}
