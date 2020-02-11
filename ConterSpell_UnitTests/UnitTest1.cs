using CounterSpell;
using System;
using Xunit;

namespace ConterSpell_UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            Assert.Equal("zeroonetwothree", Say.sample("zero"));
            Assert.Equal("zeros", Processor.Process("zero"));
        }
    }
}
