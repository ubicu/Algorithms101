
using Algorithms.Core;
using System;
using Xunit;

namespace Algorithms.Test
{
    public class DynamicArrayTest
    {
        private DynamicArray<string> dynamicArray;

        public DynamicArrayTest()
        {
            this.dynamicArray = new DynamicArray<string>(initialCapacity: 2);
        }

        [Fact]
        public void GetAndSet()
        {
            dynamicArray.Set(0, "a");
            Assert.Equal("a", dynamicArray.Get(0));
        }

        [Fact]
        public void Insert()
        {
            dynamicArray.Add("a");
            dynamicArray.Add("b");
            dynamicArray.Add("c");

            dynamicArray.Insert(index: 1, value: "d");

            Assert.Equal(4, dynamicArray.Size());
            Assert.Equal("a", dynamicArray.Get(0));
            Assert.Equal("d", dynamicArray.Get(1));
            Assert.Equal("b", dynamicArray.Get(2));
            Assert.Equal("c", dynamicArray.Get(3));
        }

        [Fact]
        public void DeleteFirstElement()
        {
            dynamicArray.Add("a");
            dynamicArray.Add("b");
            dynamicArray.Add("c");

            dynamicArray.Delete(index: 0);

            Assert.Equal(2, dynamicArray.Size());
            Assert.Equal("b", dynamicArray.Get(0));
            Assert.Equal("c", dynamicArray.Get(1));
            Assert.Null(dynamicArray.Get(2));
        }

        [Fact]
        public void DeleteMiddleElement()
        {
            dynamicArray.Add("a");
            dynamicArray.Add("b");
            dynamicArray.Add("c");

            dynamicArray.Delete(index: 1);

            Assert.Equal(2, dynamicArray.Size());
            Assert.Equal("a", dynamicArray.Get(0));
            Assert.Equal("c", dynamicArray.Get(1));
            Assert.Null(dynamicArray.Get(2));
        }

        [Fact]
        public void DeleteLastElement()
        {
            dynamicArray.Add("a");
            dynamicArray.Add("b");
            dynamicArray.Add("c");

            dynamicArray.Delete(index: 2);

            Assert.Equal(2, dynamicArray.Size());
            Assert.Equal("a", dynamicArray.Get(0));
            Assert.Equal("b", dynamicArray.Get(1));
            Assert.Null(dynamicArray.Get(2));
        }

        [Fact]
        public void IsEmpty()
        {
            Assert.True(dynamicArray.IsEmpty());

            dynamicArray.Add("a");

            Assert.False(dynamicArray.IsEmpty());
        }

        [Fact]
        public void Contains()
        {
            Assert.False(dynamicArray.Contains("a"));

            dynamicArray.Add("a");
            Assert.True(dynamicArray.Contains("a"));

            dynamicArray.Delete(0);

            Assert.False(dynamicArray.Contains("a"));

        }
    }
}
