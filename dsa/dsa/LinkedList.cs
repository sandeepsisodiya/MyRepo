using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa
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
    class LinkedList 
    {
        //LinkedListNode node = new LinkedListNode(3);

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
            if(count == 0)
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
            if(count == 0)
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

        public void RemoveFirst()
        {
            if (count == 0)
            {
                return;
            }
            else if(count == 1)
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
            if(count == 0)
            {
                return;
            }
            else if(count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                LinkedListNode current = Head;
                while(current.Next != Tail)
                {
                    current = current.Next;
                }

                current.Next = null;
                Tail = current;
            }
        }

        public void Remove(int value)
        {
            LinkedListNode previous = Head;
            LinkedListNode current = Head;
            if(count == 1 && Head.Value == value)
            {
                Head = null;
                Tail = null;
            }
            else if(count > 1)
            {
                while(current.Value != value)
                {
                    previous = current;
                    current = current.Next;
                }

                previous.Next = current.Next;
            }

            count--;
        }

        public IEnumerable<int> GetEnumrator()
        {
            LinkedListNode current = Head;
            while(current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }
}
