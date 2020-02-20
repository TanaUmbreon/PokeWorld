using System;
using System.Collections.Generic;
using NUnit.Framework;
using PokeWorld.Statistics;

namespace PokeWorld.Test.Statistics
{
    [TestFixture]
    public class ExperienceTest
    {
        [Test]
        public void TestNew()
        {
            Assert.That(() => new Experience(-1), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
            Assert.That(() => new Experience(0), Throws.Nothing);
            Assert.That(() => new Experience(int.MaxValue), Throws.Nothing);
        }

        [Test]
        public void TestValue()
        {
            var exp1 = new Experience(197);
            Assert.That(exp1.Value, Is.EqualTo(197));

            var exp2 = new Experience(1);
            Assert.That(exp2.Value, Is.EqualTo(1));
        }
        
        [Test]
        public void TestToString()
        {
            var exp1 = new Experience(197);
            Assert.That(exp1.ToString(), Is.EqualTo("197"));

            var exp2 = new Experience(1);
            Assert.That(exp2.ToString(), Is.EqualTo("1"));
        }

        [Test]
        public void TestEquals()
        {
            var exp1 = new Experience(197);
            Assert.That(exp1.ToString(), Is.EqualTo("197"));

            var exp2 = new Experience(1);
            Assert.That(exp2.ToString(), Is.EqualTo("1"));
        }

        [Test]
        public void TestSubtract()
        {
            var exp1 = new Experience(1);
            var exp2 = new Experience(2);
            Assert.That(exp2.Subtract(exp1).Value, Is.EqualTo(1));
            // 引き算を行っても元のインスタンスの値は不変であることを確認する
            Assert.That(exp2.Value, Is.EqualTo(2));

            Assert.That(exp1.Subtract(exp1).Value, Is.EqualTo(0));
            Assert.That(() => exp1.Subtract(exp2), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());

        }

        [Test]
        public void TestZero()
        {
            Assert.That(Experience.Zero.Value, Is.EqualTo(0));
        }
    }
}
