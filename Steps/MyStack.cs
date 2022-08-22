using System;
using System.Collections;
using System.Collections.Generic;

namespace Steps
{
    public class MyStack<T> : IEnumerable<T>
    {
        private T[] _items;

        public int Count { get; private set; }

        public int Capacity
        {
            get { return _items.Length; }
        }
        public MyStack()
        {
            const int defaultCapacity = 4;
            _items = new T[defaultCapacity];
        }

        public MyStack(int capacity)
        {
            _items = new T[capacity];
        }

        public void Push(T item)
        {
            if (_items.Length == Count)
            {
                T[] largerArray = new T[Count * 2];
                Array.Copy(_items, largerArray, Count);
                _items = largerArray;
            }
            _items[Count++] = item;
        }

        public void Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            _items[--Count] = default;
        }

        public T Peek()
        {
            return Count == 0 ? throw new InvalidOperationException() : _items[Count - 1];
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
