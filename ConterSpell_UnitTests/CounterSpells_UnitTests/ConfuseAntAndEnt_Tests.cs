using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ConterSpell_UnitTests.CounterSpells_UnitTests
{
    public class ConfuseAntAndEnt_Tests
    {
        [Fact]
        public void ReplaceEntWithAnt()
        {
            Assert.Equal("apparantly", CounterSpells.ConfuseAntAndEnt("apparently"));
        }

        [Fact]
        public void ReplaceAntWithEnt()
        {
            Assert.Equal("varient", CounterSpells.ConfuseAntAndEnt("variant"));
        }

        [Fact]
        public void LeaveOtherWordsAlone()
        {
            Assert.Equal("test", CounterSpells.ConfuseAntAndEnt("test"));
        }

    }
}
