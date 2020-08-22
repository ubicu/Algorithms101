using Algorithms.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Algorithms.Test
{
    public class DynamicArrayXTest
    {
        [Fact]
        public void Initialization_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new DynamicArrayX<string>(-1));
        }

        [Fact]
        public void Get_ThrowsException_EmptyArray()
        {
            var dynamicArray = new DynamicArrayX<string>();

            Assert.Throws<IndexOutOfRangeException>(() => dynamicArray.Get(0));
        }

        [Fact]
        public void Get_SuccessfulOperation()
        {
            var dynamicArray = new DynamicArrayX<string>();

            dynamicArray.Add("a");
            dynamicArray.Add("b");

            Assert.Equal("a", dynamicArray.Get(0));
            Assert.Equal("b", dynamicArray.Get(1));
        }

        [Fact]
        public void Get_ThrowsException_IndexOutOfBounds()
        {
            var dynamicArray = new DynamicArrayX<string>();

            dynamicArray.Add("a");
            dynamicArray.Add("b");

            Assert.Throws<IndexOutOfRangeException>(() => dynamicArray.Get(-1));
            Assert.Throws<IndexOutOfRangeException>(() => dynamicArray.Get(2));
        }

        [Fact]
        public void Set_ThrowsException_EmptyArray()
        {
            string insertValue = "a";

            var dynamicArray = new DynamicArrayX<string>();

            Assert.Throws<IndexOutOfRangeException>(() => dynamicArray.Set(0, insertValue));
        }

        [Fact]
        public void Set_SuccessfulOperation()
        {
            var dynamicArray = new DynamicArrayX<string>();

            dynamicArray.Add("a");
            dynamicArray.Add("b");

            dynamicArray.Set(0, "c");
            dynamicArray.Set(1, "d");

            Assert.Equal("c", dynamicArray.Get(0));
            Assert.Equal("d", dynamicArray.Get(1));
        }

        [Fact]
        public void Set_ThrowsException_IndexOutOfBounds()
        {
            var dynamicArray = new DynamicArrayX<string>();

            dynamicArray.Add("a");
            dynamicArray.Add("b");

            Assert.Throws<IndexOutOfRangeException>(() => dynamicArray.Set(-1, "c"));
            Assert.Throws<IndexOutOfRangeException>(() => dynamicArray.Set(2, "d"));
        }

        [Fact]
        public void Insert_ThrowsException_IndexOutOfBounds()
        {
            var dynamicArray = new DynamicArrayX<string>();

            dynamicArray.Add("a");
            dynamicArray.Add("b");

            Assert.Throws<IndexOutOfRangeException>(() => dynamicArray.Insert(-1, "c"));
            Assert.Throws<IndexOutOfRangeException>(() => dynamicArray.Insert(2, "d"));
        }

        [Fact]
        public void Insert_SuccessfulOperation()
        {
            var dynamicArray = new DynamicArrayX<string>();

            dynamicArray.Add("a");
            dynamicArray.Add("b");
            dynamicArray.Insert(0, "c");

            Assert.Equal(3, dynamicArray.Size());
            Assert.Equal("c", dynamicArray.Get(0));
            Assert.Equal("a", dynamicArray.Get(1));
            Assert.Equal("b", dynamicArray.Get(2));
        }

        [Fact]
        public void Delete_ThrowsException_IndexOutOfBounds()
        {
            var dynamicArray = new DynamicArrayX<string>();

            dynamicArray.Add("a");
            dynamicArray.Add("b");

            Assert.Throws<IndexOutOfRangeException>(() => dynamicArray.Delete(-1));
            Assert.Throws<IndexOutOfRangeException>(() => dynamicArray.Delete(2));
        }

        [Fact]
        public void Delete_SuccessfulOperation()
        {
            var dynamicArray = new DynamicArrayX<string>();

            dynamicArray.Add("a");
            dynamicArray.Add("b");
            dynamicArray.Add("c");

            dynamicArray.Delete(0);

            Assert.Equal(2, dynamicArray.Size());
            Assert.Equal("b", dynamicArray.Get(0));
            Assert.Equal("c", dynamicArray.Get(1));
            Assert.Throws<IndexOutOfRangeException>(() => dynamicArray.Get(2));

            dynamicArray.Delete(1);
            Assert.Equal(1, dynamicArray.Size());
            Assert.Equal("b", dynamicArray.Get(0));
            Assert.Throws<IndexOutOfRangeException>(() => dynamicArray.Get(1));
            Assert.Throws<IndexOutOfRangeException>(() => dynamicArray.Get(2));

        }
    }
}
