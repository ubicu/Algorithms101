using System;

namespace Algorithms.Core.Enhanced
{
    /*
     * Improved implementation for DynamicArray 
     * with argument and index validation
     */
    public class DynamicArrayX<T>
    {
        #region Array Notes
        /*
            Get/Set - O(1)
            Insert  - O(n)
            Delete  - O(n)

            Killer Features:
            (1) Random access
            (2) Fixed capacity - use dynamic array implementation to automatically resize
            (3) Double when resize
        */
        #endregion

        private T[] _data;
        private int _size;
        private int _initialCapacity;

        public DynamicArrayX(int initialCapacity = 10)
        {
            if (initialCapacity < 0)
            {
                throw new ArgumentOutOfRangeException("Initial capacity must be non-negative");
            }

            this._initialCapacity = initialCapacity;
            this._data = new T[initialCapacity];
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _size)
            {
                throw new IndexOutOfRangeException($"Index must be non-negative and less than size (currently at {_size} of dynamic array.");
            }

            return _data[index];
        }

        public void Set(int index, T value)
        {
            if (index < 0 || index >= _size)
            {
                throw new IndexOutOfRangeException($"Index must be non-negative and less than size (currently at {_size} of dynamic array.");
            }

            _data[index] = value;
        }

        public void Add(T value)
        {
            if (_size == _initialCapacity)
            {
                resize();
            }

            _data[_size] = value;
            _size++;
        }

        public int Size()
        {
            return _size;
        }

        public void Insert(int index, T value)
        {
            if (index < 0 || index >= _size)
            {
                throw new IndexOutOfRangeException($"Index must be non-negative and less than size (currently at {_size} of dynamic array.");
            }

            // Check size
            if (_size == _initialCapacity)
            {
                resize();
            }

            // Copy up
            for (int j = _size; j > index; j--)
            {
                _data[j] = _data[j - 1];
            }

            // Insert
            _data[index] = value;
            _size++;
        }

        public void Delete(int index)
        {
            if (index < 0 || index >= _size)
            {
                throw new IndexOutOfRangeException($"Index must be non-negative and less than size (currently at {_size} of dynamic array.");
            }

            _data[index] = default(T);

            // Copy down
            for (int j = index; j < _size; j++)
            {
                _data[j] = _data[j + 1];
            }

            _size--;
        }

        #region Private methods
        private void resize()
        {
            T[] newData = new T[_initialCapacity * 2];
            for (int i = 0; i < _initialCapacity; i++)
            {
                newData[i] = _data[i];
            }

            _data = newData;
            _initialCapacity = _initialCapacity * 2;
        }
        #endregion
    }
}
