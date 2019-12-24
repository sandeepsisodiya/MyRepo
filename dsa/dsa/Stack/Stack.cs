using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dsa.LinkedList;

namespace dsa.Stack
{
    class Stack
    {
        //Use the Linked List Class
        LinkedList.LinkedList _linkedlist = new dsa.LinkedList.LinkedList();

        public void Push(int val)
        {
            _linkedlist.AddFirst(val);
        }

        public int Pop()
        {
            if (_linkedlist.Count == 0)
            {
                throw new InvalidOperationException("Stack is Empty");
            }

            int value = _linkedlist.Head.Value;
            _linkedlist.RemoveFirst();
            return value;
        }

        public int Peek()
        {
            if (_linkedlist.Count == 0)
            {
                throw new InvalidOperationException("Stack is Empty");
            }

            return _linkedlist.Head.Value;
        }

        public void Clear()
        {
            _linkedlist.Clear();
        }

        public int Count
        {
            get { return _linkedlist.Count; }
        }

        public IEnumerable<int> GetEnumerator()
        {
           return _linkedlist.GetEnumrator();
        }
    }

}
