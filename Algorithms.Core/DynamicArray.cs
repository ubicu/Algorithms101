using System;

namespace Algorithms.Core
{
    public class DynamicArray<T>
    {
        private T[] _data;
        private int _size;
        private int _initialCapacity;

        public DynamicArray(int initialCapacity)
        {
            this._initialCapacity = initialCapacity;
            this._data = new T[initialCapacity];
        }

        public T Get(int index)
        {
            return _data[index];
        }

        public void Set(int index, T value)
        {
            _data[index] = value;
        }
    }
}
