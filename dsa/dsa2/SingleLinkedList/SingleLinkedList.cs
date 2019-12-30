using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa2.SingleLinkedList
{
    class Node
    {
        public Node(int value)
        {
            Value = value;
        }
        public int Value;
        public Node Next;
    }

    class SingleLinkedList
    {
        Node Head;
        Node Tail;
        int count;

        public void AddToFront(int value)
        {
            Node node = new Node(value);
            if (count == 0)
            {
                Head = node;
                Tail = Head;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
            count++;
        }

        public void AddToLast(int value)
        {
            Node node = new Node(value);
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

        public void AddBefore(int addvalue, int findvalue)
        {
            Node current = Head;
            Node prev = null;

            while(current!= null)
            {
                if(current.Value == findvalue)
                {
                    break;
                }
                prev = current;
                current = current.Next;
            }

            if(current == null)
            {
                AddToLast(addvalue);
            }
            else
            {
                Node node = new Node(addvalue);
                node.Next = current;
                prev.Next = node;
                count++;
            }
        }

        public void AddAfter(int addvalue, int findvalue)
        {
            Node current = Head;

            while(current != null)
            {
                if (current.Value == findvalue)
                {
                    break;
                }
                current = current.Next;
            }

            if(current != null)
            {
                Node node = new Node(addvalue);
                node.Next = current.Next;
                current.Next = node;
                count++;
            }
            else
            {
                AddToLast(addvalue);
            }
            
        }

        public void AddByPosition(int addvalue, int position)
        {
            Node current = Head;
            
            for(int i=1; i < position-1 && current != null; i++)
            {
                current = current.Next;
            }

            if(current == null)
            {
                AddToLast(addvalue);
            }
            else
            {
                AddAfter(addvalue, current.Value);
            }

        }

        public void RemoveFromFront()
        {
            if(count > 0)
            {
                if(count == 1)
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
        }


        public void RemoveFromLast()
        {
            if(count > 0)
            {
                if(count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Node current = Head;
                    while(current.Next != Tail)
                    {
                        current = current.Next;
                    }
                    current.Next = null;
                    Tail = current;
                }
                count--;
            }

        }

        public void RemoveAt(int findvalue)
        {
            Node current = Head;
            Node prev = null;
            if(count == 0)
            {
                return;
            }
            else if (count == 1)
            {
                if(current.Value == findvalue)
                {
                    Head = null;
                    Tail = null;
                }
            }
            else
            {
                while(current != null)
                {
                    if(current.Value == findvalue)
                    {
                        if(prev == null)
                        {
                            RemoveFromFront();
                        }
                        else
                        {
                            prev.Next = current.Next;
                            count--;
                        }
                    }

                    prev = current;
                    current = current.Next;

                    if(current == null)
                    {
                        Tail = prev;
                    }
                }
            }

        }

        public void RemoveAtIndex(int index)
        {
            if(index < count)
            {
                Node current = Head;
                Node prev = null;
                for(int i=0; i < index; i++)
                {
                    prev = current;
                    current = current.Next;
                }

                if (count > 1 && index > 0)
                {
                    prev.Next = current.Next;
                }
                else if(index == 0)
                {
                    RemoveFromFront();
                }
                else
                {
                    Head = null;
                    Tail = null;
                }

                count--;
            }
        }

        public void ReverseLinkedList()
        {
            Node prev = null;
            Node next = null;
            Node current = Head;
            Tail = Head;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            Head = prev;
        }

        public void BubbleSortByData()
        {
            BuubleSort.BubbleSortByData(Head);
        }

        public void BubbleSortByReference()
        {
            BuubleSort.BubbleSortByReference(Head);
        }

        public void Print()
        {
            if(Head != null)
            {
                Node current = Head;
                while (current != null)
                {
                    Console.WriteLine(current.Value);
                    current = current.Next;
                }
            }
        }
    }
}
