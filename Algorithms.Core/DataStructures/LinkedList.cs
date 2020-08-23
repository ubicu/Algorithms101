using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Core
{
    public class LinkedList<T>
    {
        #region LinkedList Notes
        /*
          Add front - O(1)
          Add back  - O(n)
          Delete    - O(n)

          Disadvantages:
          (a) no random access, unlike array

          Advantages:
          (a) no fixed capacity
          (b) always the right size
        */
        #endregion

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

        public void AddFront(T data)
        {
            // Create new node
            var newNode = new Node<T>(data);

            // If linked list is empty
            if (_head == null)
            {
                _head = newNode;
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

            // If list is empty
            if (_head == null)
            {
                _head = newNode;
                return;
            }

            // Iterate until the end of list
            Node<T> current = _head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            // Point current to new node
            current.Next = newNode;
        }

        public T GetFirst()
        {
            return _head.data;
        }

        public T GetLast()
        {
            if (_head == null)
            {
                throw new InvalidOperationException("The list is empty.");
            }

            Node<T> current = _head;
            while(current.Next != null)
            {
                current = current.Next;
            }

            return current.data;
        }

        public int Size()
        {
            if (_head == null)
            {
                return 0;
            }

            int size = 1;
            Node<T> current = _head;
            while (current.Next != null)
            {
                current = current.Next;
                size++;
            }

            return size;
        }

        public void Clear()
        {
            _head = null;
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
                return;
            }

            // Iterate until the end of list or value is found
            Node<T> current = _head;
            while (current.Next != null)
            {
                if (current.Next.data.Equals(value))
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }
    }
}
