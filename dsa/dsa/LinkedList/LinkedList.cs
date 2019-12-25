using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.LinkedList
{
    public class LinkedListNode
    {
        public int Value { get; set; }

        public LinkedListNode(int value)
        {
            Value = value;
        }

        public LinkedListNode Next { get; set; }
    }
    public class LinkedList
    {
        public LinkedListNode Head { get; private set; }
        public LinkedListNode Tail { get; private set; }

        int count = 0;

        public void AddFirst(int value)
        {
            AddFirst(new LinkedListNode(value));
        }

        public void AddFirst(LinkedListNode node)
        {
            LinkedListNode temp = Head;
            if (count == 0)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                temp = Head;
                Head = node;
                Head.Next = temp;
            }
            count++;
        }

        public void AddLast(int value)
        {
            AddLast(new LinkedListNode(value));
        }

        public void AddLast(LinkedListNode node)
        {
            if (count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }

            Tail = node;
            count++;
        }

        public void AddBefore(int val, int before)
        {
            AddBefore(new LinkedListNode(val), before);
        }

        public void AddBefore(LinkedListNode node, int before)
        {
            LinkedListNode prev = null;
            LinkedListNode current = Head;

            while (current != null)
            {
                if (current.Value == before)
                {
                    if(prev == null)
                    {
                        AddFirst(node);
                    }
                    else
                    {
                        prev.Next = node;
                        node.Next = current;
                    }

                    break;
                }

                prev = current;
                current = current.Next;
            }
            if (prev == null)
            {
                Head = node;
                Tail = Head;
            }
        }

        public void RemoveFirst()
        {
            if (count == 0)
            {
                return;
            }
            else if (count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Next;
            }
            count--;
        }

        public void RemoveLast()
        {
            if (count == 0)
            {
                return;
            }
            else if (count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                LinkedListNode current = Head;
                while (current.Next != Tail)
                {
                    current = current.Next;
                }

                current.Next = null;
                Tail = current;
            }
            count--;
        }

        public void Remove(int value)
        {
            LinkedListNode previous = null;
            LinkedListNode current = Head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        count--;

                        if (current.Next == null)
                        {
                            Tail = previous;
                        }
                    }
                    else
                    {
                        RemoveFirst();
                    }
                }
                previous = current;
                current = current.Next;
            }
        }

        public int Count
        {
            get { return count; }
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
        }

        public IEnumerable<int> GetEnumrator()
        {
            LinkedListNode current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public void PrintLinkedList(LinkedList locadllst)
        {
            foreach (int val in locadllst.GetEnumrator())
            {
                Console.WriteLine(val);
            }
        }
    }
}
