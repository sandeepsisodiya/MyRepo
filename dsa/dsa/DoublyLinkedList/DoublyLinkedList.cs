using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.DoublyLinkedList
{
    public class DoublyLinkedListNode
    {
        public int Value { get; set; }

        public DoublyLinkedListNode(int value)
        {
            Value = value;
        }
        public DoublyLinkedListNode Prev { get; set; }
        public DoublyLinkedListNode Next { get; set; }
    }

    public class DoublyLinkedList
    {

        public DoublyLinkedListNode Head { get; private set; }
        public DoublyLinkedListNode Tail { get; private set; }

        int count = 0;

        public void AddFirst(int value)
        {
            AddFirst(new DoublyLinkedListNode(value));
        }

        public void AddFirst(DoublyLinkedListNode node)
        {
            DoublyLinkedListNode temp = Head;
            if(count == 0)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Head = node;
                Head.Next = temp;
                temp.Prev = Head;
            }
            count++;
        }

        public void AddLast(int value)
        {
            AddLast(new DoublyLinkedListNode(value));
        }

        public void AddLast(DoublyLinkedListNode node)
        {
            if(count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Prev = Tail;
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
                Head.Prev = null;
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
                Tail.Prev.Next = null;
                Tail = Tail.Prev;
            }
            count--;
        }

        public void Remove(int value)
        {
            DoublyLinkedListNode previous = null;
            DoublyLinkedListNode current = Head;

            while(current !=null)
            {
                if(current.Value.Equals(value))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        count--;

                        if(current.Next == null)
                        {
                            Tail = previous;
                        }
                        else
                        {
                            //Only in case of middle element removal. we set the prev
                            current.Next.Prev = previous;
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

        public IEnumerable<int> GetEnumrator()
        {
            DoublyLinkedListNode current = Head;
            while(current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public void PrintDoublyLinkedList(DoublyLinkedList locadllst)
        {
            foreach (int val in locadllst.GetEnumrator())
            {
                Console.WriteLine(val);
            }
        }
    }
}
