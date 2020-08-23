
using Xunit;
using Algorithms.Core;

namespace Algorithms.Test
{
    public class LinkedListTest
    {
        [Fact]
        public void AddFront()
        {
            var linkedList = new LinkedList<int>();

            linkedList.AddFront(1);
            linkedList.AddFront(2);
            linkedList.AddFront(3);

            Assert.Equal(3, linkedList.Size());
            Assert.Equal(3, linkedList.GetFirst());
            Assert.Equal(1, linkedList.GetLast());
        }

        [Fact]
        public void GetFirst()
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddFront(1);

            Assert.Equal(1, linkedList.GetFirst());
        }

        [Fact]
        public void GetLast()
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddFront(1);

            Assert.Equal(1, linkedList.GetLast());

            linkedList.AddFront(2);
            Assert.Equal(1, linkedList.GetLast());
        }

        [Fact]
        public void AddBack()
        {
            var linkedList = new LinkedList<int>();

            linkedList.AddBack(1);
            linkedList.AddBack(2);
            linkedList.AddBack(3);

            Assert.Equal(3, linkedList.Size());
            Assert.Equal(1, linkedList.GetFirst());
            Assert.Equal(3, linkedList.GetLast());
        }

        [Fact]
        public void Size()
        {
            var linkedList = new LinkedList<int>();

            Assert.Equal(0, linkedList.Size());

            linkedList.AddFront(1);
            linkedList.AddBack(2);

            Assert.Equal(2, linkedList.Size());
        }

        [Fact]
        public void Clear()
        {
            var linkedList = new LinkedList<int>();

            linkedList.AddBack(1);
            linkedList.AddBack(2);
            linkedList.AddBack(3);

            Assert.Equal(3, linkedList.Size());

            linkedList.Clear();

            Assert.Equal(0, linkedList.Size());
        }

        [Fact]
        public void DeleteValue()
        {
            var linkedList = new LinkedList<int>();

            linkedList.AddBack(1);
            linkedList.AddBack(2);
            linkedList.AddBack(3);

            linkedList.DeleteValue(2);

            Assert.Equal(2, linkedList.Size());
            Assert.Equal(1, linkedList.GetFirst());
            Assert.Equal(3, linkedList.GetLast());
        }

        [Fact]
        public void DeleteLastValue()
        {
            var linkedList = new LinkedList<int>();

            linkedList.AddBack(1);
            linkedList.AddBack(2);
            linkedList.AddBack(3);
            linkedList.AddBack(4);

            linkedList.DeleteValue(4);

            Assert.Equal(3, linkedList.Size());
            Assert.Equal(1, linkedList.GetFirst());
            Assert.Equal(3, linkedList.GetLast());
        }
    }
}
