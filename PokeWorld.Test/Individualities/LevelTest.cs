using System;
using System.Collections.Generic;
using NUnit.Framework;
using PokeWorld.Individualities;

namespace PokeWorld.Test.Individualities
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

        [Test]
        public void TestIsMin()
        {
            var lv1 = new Level(1);
            Assert.That(lv1.IsMin, Is.True);
            var lv2 = new Level(2);
            Assert.That(lv2.IsMin, Is.False);
        }

        [Test]
        public void TestIsMax()
        {
            var lv1 = new Level(100);
            Assert.That(lv1.IsMax, Is.True);
            var lv2 = new Level(99);
            Assert.That(lv2.IsMax, Is.False);
        }

        [Test]
        public void TestGetNext()
        {
            var lv1 = new Level(1);
            Assert.That(lv1.GetNext().Value, Is.EqualTo(2));
            var lv2 = new Level(99);
            Assert.That(lv2.GetNext().Value, Is.EqualTo(100));
            var lv3 = new Level(100);
            Assert.That(() => lv3.GetNext(), Throws.InvalidOperationException);
        }

        [Test]
        public void TestToString()
        {
            var lv1 = new Level(5);
            Assert.That(lv1.ToString(), Is.EqualTo("5"));

            var lv2 = new Level(100);
            Assert.That(lv2.ToString(), Is.EqualTo("100"));
        }
    }
}
