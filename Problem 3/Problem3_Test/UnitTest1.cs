using System;
using Xunit;
using Problem3;
using System.Collections.Generic;

namespace Problem3_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            List<int> testList = new List<int> { 4, 6, 5, 3, 3, 1, 3, 4, 3};
            Service _service = new Service();

            var result = _service.PickingNumbers(testList);

            Assert.Equal(5, result);
            Assert.NotEqual(6, result);
        }
    }
}
