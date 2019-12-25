using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dsa.LinkedList;

namespace dsa.Queue
{
    class PriorityQueue
    {
        LinkedList.LinkedList _linkedList = new LinkedList.LinkedList();

        public void Enqueue(int val)
        {
            if (_linkedList.Count == 0)
            {
                _linkedList.AddLast(val);
            }
            else
            {
                LinkedListNode current = _linkedList.Head;
                while (current != null &&  current.Value.CompareTo(val) < 0)
                {
                    current = current.Next;
                }

                if(current == null)
                {
                    _linkedList.AddLast(val);
                }
                else
                {
                    _linkedList.AddBefore(val, current.Value);
                }
            }
        }

        public int Dequeue()
        {
            if (_linkedList.Count == 0)
            {
                throw new InvalidOperationException();
            }

            int ret = _linkedList.Head.Value;
            _linkedList.RemoveFirst();
            return ret;
        }

        public int Peek()
        {
            if (_linkedList.Count == 0)
            {
                throw new InvalidOperationException();
            }
            return _linkedList.Head.Value;
        }

        public int Count()
        {
            return _linkedList.Count;
        }

        public void Clear()
        {
            _linkedList.Clear();
        }

        public IEnumerable<int> GetEnumerator()
        {
            return _linkedList.GetEnumrator();
        }
    }
}
