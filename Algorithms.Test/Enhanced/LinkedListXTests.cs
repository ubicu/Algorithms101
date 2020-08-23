using Algorithms.Core.Enhanced;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Algorithms.Test.Enhanced
{
    public class LinkedListXTests
    {
        [Fact]
        public void AddFront_SuccessfulOperation()
        {
            var linkedList = new LinkedListX<int>();

            linkedList.AddFront(1);
            linkedList.AddFront(2);
            linkedList.AddFront(3);

            Assert.Equal(3, linkedList.Size());
            Assert.Equal(3, linkedList.GetFirst());
            Assert.Equal(1, linkedList.GetLast());
        }

        [Fact]
        public void AddBack_SuccessfulOperation()
        {
            var linkedList = new LinkedListX<int>();

            linkedList.AddBack(1);
            linkedList.AddBack(2);
            linkedList.AddBack(3);

            Assert.Equal(3, linkedList.Size());
            Assert.Equal(1, linkedList.GetFirst());
            Assert.Equal(3, linkedList.GetLast());
        }

        [Fact]
        public void GetFirst_SuccessfulOperation()
        {
            var linkedList = new LinkedListX<int>();
            linkedList.AddFront(1);

            Assert.Equal(1, linkedList.GetFirst());
        }

        [Fact]
        public void GetLast_SuccessfulOperation()
        {
            var linkedList = new LinkedListX<int>();
            linkedList.AddFront(1);

            Assert.Equal(1, linkedList.GetLast());

            linkedList.AddFront(2);
            Assert.Equal(1, linkedList.GetLast());
        }

        [Fact]
        public void Size_SuccessfulOperation()
        {
            var linkedList = new LinkedListX<int>();

            Assert.Equal(0, linkedList.Size());

            linkedList.AddFront(1);
            linkedList.AddBack(2);

            Assert.Equal(2, linkedList.Size());
        }

        [Fact]
        public void Clear_SuccessfulOperation()
        {
            var linkedList = new LinkedListX<int>();

            linkedList.AddBack(1);
            linkedList.AddBack(2);
            linkedList.AddBack(3);

            Assert.Equal(3, linkedList.Size());

            linkedList.Clear();

            Assert.Equal(0, linkedList.Size());
        }

        [Fact]
        public void DeleteValue_SuccessfulOperation()
        {
            var linkedList = new LinkedListX<int>();

            linkedList.AddBack(1);
            linkedList.AddBack(2);
            linkedList.AddBack(3);

            linkedList.DeleteValue(2);

            Assert.Equal(2, linkedList.Size());
            Assert.Equal(1, linkedList.GetFirst());
            Assert.Equal(3, linkedList.GetLast());
        }

        [Fact]
        public void DeleteLastValue_SuccessfulOperation()
        {
            var linkedList = new LinkedListX<int>();

            linkedList.AddBack(1);
            linkedList.AddBack(2);
            linkedList.AddBack(3);
            linkedList.AddBack(4);

            linkedList.DeleteValue(4);

            Assert.Equal(3, linkedList.Size());
            Assert.Equal(1, linkedList.GetFirst());
            Assert.Equal(3, linkedList.GetLast());
        }

        [Fact]
        public void DeletValue_ListWithOneElement_SuccessfulOperation()
        {
            var linkedList = new LinkedListX<int>();

            linkedList.AddFront(1);

            linkedList.DeleteValue(1);

            Assert.Equal(0, linkedList.Size());
            Assert.Throws<InvalidOperationException>(() => linkedList.GetFirst());
            Assert.Throws<InvalidOperationException>(() => linkedList.GetLast());
        }
    }
}
