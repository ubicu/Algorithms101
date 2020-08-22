
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

    }
}
