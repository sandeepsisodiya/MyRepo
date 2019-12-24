using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dsa.LinkedList;

namespace dsa.Queue
{
    public class QueueLinkedList
    {
        LinkedList.LinkedList _linkedList = new LinkedList.LinkedList();

        public void Enqueue(int val)
        {
            _linkedList.AddLast(val);
        }

        public int Dequeue()
        {
            if(_linkedList.Count == 0)
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

        public int Count
        {
            get { return _linkedList.Count; }
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
