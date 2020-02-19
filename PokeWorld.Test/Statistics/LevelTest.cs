using System;
using System.Collections.Generic;
using NUnit.Framework;
using PokeWorld.Statistics;

namespace PokeWorld.Test.Statistics
{
    [TestFixture]
    public class LevelTest
    {
        [Test]
        public void TestNew()
        {
            Assert.That(() => new Level(0), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
            Assert.That(() => new Level(1), Throws.Nothing);
            Assert.That(() => new Level(100), Throws.Nothing);
            Assert.That(() => new Level(101), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void TestValue()
        {
            var lv1 = new Level(5);
            Assert.That(lv1.Value, Is.EqualTo(5));

            var lv2 = new Level(100);
            Assert.That(lv2.Value, Is.EqualTo(100));
        }
    }
}
