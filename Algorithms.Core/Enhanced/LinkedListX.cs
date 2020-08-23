using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Core.Enhanced
{
    /*
     * Enhanced implementation for LinkedList:
     * (a) adding a tail node to make the AddBack/GetLast O(1)
     * (b) adding a size property to make Size() operation O(1)
     * (c) validation for empty lists GetFirst/GetLast operation
     */
    public class LinkedListX<T>
    {
        #region Node class
        private class Node<T>
        {
            public T data { get; private set; }
            public Node<T> Next { get; set; }

            public Node(T data)
            {
                this.data = data;
            }
        }
        #endregion

        private Node<T> _head;
        private Node<T> _tail;
        private int _size;

        public LinkedListX()
        {
            _head = null;
            _tail = null;
            _size = 0;
        }

        public int Size()
        {
            return _size;
        }

        public void AddFront(T data)
        {
            // Create new node
            var newNode = new Node<T>(data);

            // Increase size
            _size++;

            // If linked list is empty
            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
                return;
            }

            // Set new node next to the current head
            newNode.Next = _head;

            // Set current head to new node
            _head = newNode;
        }

        public void AddBack(T data)
        {
            // Create new node
            var newNode = new Node<T>(data);

            // Increase size
            _size++;

            // If linked list is empty
            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
                return;
            }

            // Set the current tail next to new node
            _tail.Next = newNode;

            // Set tail to new node
            _tail = newNode;
        }

        public T GetFirst()
        {
            if (_head == null)
            {
                throw new InvalidOperationException("The list is empty.");
            }

            return _head.data;
        }

        public T GetLast()
        {
            if (_head == null)
            {
                throw new InvalidOperationException("The list is empty.");
            }

            return _tail.data;
        }

        public void Clear()
        {
            _head = null;
            _tail = null;

            _size = 0;
        }

        public void DeleteValue(T value)
        {
            if (_head == null)
            {
                return;
            }

            // Head contains data
            if (_head.data.Equals(value))
            {
                _head = _head.Next;

                if (_size == 1) // List has one element and head/tail point to the same node
                {
                    _tail = null;
                }

                _size--;

                return;
            }

            // Iterate until the end of list or value is found
            Node<T> current = _head;
            while (current.Next != null)
            {
                if (current.Next.data.Equals(value))
                {
                    current.Next = current.Next.Next;

                    if (current.Next == null) // reached tail
                    {
                        _tail = current;
                    }

                    _size--;
                    return;
                }
                current = current.Next;
            }
        }
    }
}
