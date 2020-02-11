using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ConterSpell_UnitTests.CounterSpells_UnitTests
{
    public class ConfuseAnceAndEnce_Tests
    {
        [Fact]
        public void ReplaceAnceWithEnce()
        {
            Assert.Equal("existance", CounterSpells.ConfuseAnceAndEnce("existence"));
        }

        [Fact]
        public void ReplaceEnceWithAnce()
        {
            Assert.Equal("resistence", CounterSpells.ConfuseAnceAndEnce("resistance"));
        }

        [Fact]
        public void LeaveOtherWordsAlone()
        {
            Assert.Equal("test", CounterSpells.ConfuseAnceAndEnce("test"));
        }

    }
}
