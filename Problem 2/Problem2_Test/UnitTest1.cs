using System;
using Xunit;
using Problem2;

namespace Problem2_Test
{
    public class UnitTest1
    {
        private static readonly Random _random = new Random();

        [Fact]
        public void Test1()
        {
            int[] arrayNum = { 1, 2, 3 };
            int rotation = 2;
            int[] queries = { 0, 1, 2 };

            Service _service = new Service();
            var result = _service.CircularArrayRotation(arrayNum, rotation, queries);

            Assert.NotEqual(12, result[0]);
            Assert.Equal(3, result[1]);
            Assert.Equal(1, result[2]);
        }
    }
}
