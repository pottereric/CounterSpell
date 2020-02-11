using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ConterSpell_UnitTests.CounterSpells_UnitTests
{
    public class TransposeIAndE_Tests
    {
        [Fact]
        public void TransposeIE()
        {
            Assert.Equal("acheive", CounterSpells.TransposeIAndE("achieve"));
        }

        [Fact]
        public void TransposeEI()
        {
            Assert.Equal("foriegn", CounterSpells.TransposeIAndE("foreign"));
        }

        [Fact]
        public void LeaveOtherWordsAlone()
        {
            Assert.Equal("test", CounterSpells.TransposeIAndE("test"));
        }

    }
}
