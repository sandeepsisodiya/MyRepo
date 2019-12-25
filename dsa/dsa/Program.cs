using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dsa.Queue;


namespace dsa
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedList();
            //DoublyLinkedList();
            //StackArray();
            //Stack();

            //string line = Console.ReadLine();
            //PostFixCalculator(line.Split(' '));

            //QueueLinkedList();

            PriorityQueue();
        }

        static void LinkedList()
        {
            LinkedList.LinkedList llst = new LinkedList.LinkedList();

            llst.AddBefore(3, 7);
            llst.AddBefore(7, 7);
            llst.AddBefore(5, 7);
            /*
            llst.AddLast(9);
            llst.AddLast(11);
            llst.AddLast(13);
            llst.AddLast(15);
            llst.AddLast(17);
            llst.AddLast(19);
            llst.AddLast(21);
            llst.AddLast(23);

            llst.PrintLinkedList(llst);
            Console.WriteLine("Remove 17");
            llst.Remove(17);
            llst.PrintLinkedList(llst);

            Console.WriteLine("Remove 13");
            llst.Remove(13);
            llst.PrintLinkedList(llst);

            Console.WriteLine("Remove 21");
            llst.Remove(21);
            llst.PrintLinkedList(llst);

            Console.WriteLine("Remove 23");
            llst.Remove(23);
            llst.PrintLinkedList(llst);

            Console.WriteLine("Remove 9");
            llst.Remove(9);
            llst.PrintLinkedList(llst);
            */

            Console.Read();
        }

        static void DoublyLinkedList()
        {
            DoublyLinkedList.DoublyLinkedList dllst = new DoublyLinkedList.DoublyLinkedList();

            dllst.AddLast(9);
            dllst.AddLast(11);
            dllst.AddLast(13);
            dllst.AddLast(15);
            dllst.AddLast(17);
            dllst.AddLast(19);
            dllst.AddLast(21);
            dllst.AddLast(23);

            dllst.PrintDoublyLinkedList(dllst);
            Console.WriteLine("Remove 17");
            dllst.Remove(17);
            dllst.PrintDoublyLinkedList(dllst);

            Console.WriteLine("Remove 13");
            dllst.Remove(13);
            dllst.PrintDoublyLinkedList(dllst);

            Console.WriteLine("Remove 21");
            dllst.Remove(21);
            dllst.PrintDoublyLinkedList(dllst);

            Console.WriteLine("Remove 23");
            dllst.Remove(23);
            dllst.PrintDoublyLinkedList(dllst);

            Console.WriteLine("Remove 9");
            dllst.Remove(9);
            dllst.PrintDoublyLinkedList(dllst);

            Console.Read();
        }

        static void StackArray()
        {
            Stack.StackArray stackarr = new Stack.StackArray();

            stackarr.Push(9);
            stackarr.Push(8);
            stackarr.Push(7);
            stackarr.Push(6);
            stackarr.Push(5);
            stackarr.Push(4);
            stackarr.Push(3);
            stackarr.Push(2);
            stackarr.Push(1);

            foreach(int val in stackarr.GetEnumerator())
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("Peek");
            Console.WriteLine(stackarr.Peek());
            Console.WriteLine(stackarr.Peek());
            Console.WriteLine(stackarr.Peek());
            Console.WriteLine(stackarr.Peek());

            Console.WriteLine("Pop");
            Console.WriteLine(stackarr.Pop());
            Console.WriteLine(stackarr.Pop());
            Console.WriteLine(stackarr.Pop());
            Console.WriteLine(stackarr.Pop());

            Console.WriteLine("Remaining");
            foreach (int val in stackarr.GetEnumerator())
            {
                Console.WriteLine(val);
            }

            Console.Read();

        }

        static void Stack()
        {
            Stack.Stack stack = new Stack.Stack();

            stack.Push(9);
            stack.Push(8);
            stack.Push(7);
            stack.Push(6);
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);

            foreach (int val in stack.GetEnumerator())
            {
                Console.WriteLine(val);
            }


            Console.WriteLine("Peek");
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());

            Console.WriteLine("Pop");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Console.WriteLine("Remaining");
            foreach (int val in stack.GetEnumerator())
            {
                Console.WriteLine(val);
            }

            Console.Read();

        }

        static void PostFixCalculator(string[] args)
        {
            PostFixCalculator.PostFixCalculator pfc = new PostFixCalculator.PostFixCalculator();
            pfc.Calculate(args);

            Console.Read();
        }

        static void QueueLinkedList()
        {
            QueueLinkedList queue = new QueueLinkedList();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);

            foreach (int val in queue.GetEnumerator())
            {
                Console.WriteLine(val);
            }


            Console.WriteLine("Peek");
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Peek());

            Console.WriteLine("Pop");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            Console.WriteLine("Remaining");
            foreach (int val in queue.GetEnumerator())
            {
                Console.WriteLine(val);
            }

            Console.Read();

        }

        static void PriorityQueue()
        {
            PriorityQueue pq = new PriorityQueue();

            pq.Enqueue(3);
            pq.Enqueue(7);
            pq.Enqueue(5);
            pq.Enqueue(8);
            pq.Enqueue(9);
            pq.Enqueue(6);
            pq.Enqueue(11);
            pq.Enqueue(2);

            foreach (int val in pq.GetEnumerator())
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("Peek");
            Console.WriteLine(pq.Peek());
            Console.WriteLine(pq.Peek());

            Console.WriteLine("Dequeue");
            Console.WriteLine(pq.Dequeue());
            Console.WriteLine(pq.Dequeue());
            Console.WriteLine(pq.Dequeue());
            Console.WriteLine(pq.Dequeue());

            Console.WriteLine("Peek");
            Console.WriteLine(pq.Peek());
            Console.WriteLine(pq.Peek());

            Console.WriteLine("Remaining");
            foreach (int val in pq.GetEnumerator())
            {
                Console.WriteLine(val);
            }


            Console.Read();
        }
    }
}
