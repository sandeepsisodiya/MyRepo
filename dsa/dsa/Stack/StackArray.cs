using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Stack
{
    class StackArray
    {
        int[] _items = new int[0];

        int _size;

        public void Push(int value)
        {
            if(_size == _items.Length)
            {
                int newLength = _size == 0 ? 4 : _size * 2;
                int[] newArray = new int[newLength];

                _items.CopyTo(newArray, 0);
                _items = newArray;
            }

            _items[_size] = value;
            _size++;
        }

        public int Pop()
        {
            if(_size == 0)
            {
                throw new InvalidOperationException("Stack is Empty");
            }

            _size--;
            return _items[_size];
        }

        public int Peek()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("Stack is Empty");
            }

            return _items[_size - 1];
        }

        public int Count()
        {
            return _size;
        }

        public void Clear()
        {
            _size = 0;
        }

        public IEnumerable<int> GetEnumerator()
        {
            for (int i = _size -1; i >= 0; i--)
            {
                yield return _items[i];
            }
        }

    }
}
