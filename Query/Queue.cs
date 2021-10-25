using System;
using System.Collections;
using System.Collections.Generic;

namespace Query
{
    
    public class Queue <T>: IList<T>
    {
        private Element<T> head;
        private Element<T> tail;

        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count { get; private set; }

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            Element<T> newElem = new Element<T>(item, tail);
            tail.next = newElem;
            tail = newElem;
        }

        public void Clear()
        {
            Count = 0;
            head = null;
            tail = null;
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        private class Enumerator : IEnumerator
        {
            public object Current => head;

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}
