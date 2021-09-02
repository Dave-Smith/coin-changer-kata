using System;
using Xunit;
using coin_changer;

namespace coin_changer.tests
{
    public class UnitTest1
    {
        [Fact]
        public void NinetyNineCents()
        {
            var result = Change.Make(99);
            Assert.Equal(new [] {3, 2, 0, 4}, result);
        }
    }
}
