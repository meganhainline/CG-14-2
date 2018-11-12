using System;
using Xunit;

namespace XUnitTestProject1
{
    public class ProgramTest
    {
        //[Fact]
        //public void num1_blank()
        //{
        //    var result = ProgramTest.num1(" ");
        //    Assert.Equals(null, result);
        //}

        [Fact]
        public void PassingTest()
        {
            var result = Add(2, 2);
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            var result = Add(2, 2);
            Assert.NotEqual(5, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }


    }
}