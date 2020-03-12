using System;
using System.Collections.Generic;
using NUnit.Framework;
using PokeWorld.Individualities;

namespace PokeWorld.Test.Individualities
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
            var exp197 = new Experience(197);
            Assert.That(exp197.Value, Is.EqualTo(197));

            var exp1 = new Experience(1);
            Assert.That(exp1.Value, Is.EqualTo(1));
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
        public void TestToString()
        {
            var exp197 = new Experience(197);
            Assert.That(exp197.ToString(), Is.EqualTo("197"));

            var exp1 = new Experience(1);
            Assert.That(exp1.ToString(), Is.EqualTo("1"));
        }

        [Test]
        public void TestEquals()
        {
            var exp197a = new Experience(197);
            var exp197b = new Experience(197);
            var exp1a = new Experience(1);
            var exp1b = new Experience(1);
            var obj = new object();

            Assert.That(exp197a.Equals(exp197a), Is.True);
            Assert.That(exp197a.Equals(exp197b), Is.True);
            Assert.That(exp197a.Equals(new Experience(197)), Is.True);
            Assert.That(exp1a.Equals(exp1a), Is.True);
            Assert.That(exp1a.Equals(exp1b), Is.True);
            Assert.That(exp1a.Equals(new Experience(1)), Is.True);
            Assert.That(exp197a.Equals(exp1a), Is.False);
            Assert.That(exp197a.Equals(obj), Is.False);

            // 暗黙的なEqualsメソッド呼び出しでの確認
            Assert.That(exp197a, Is.EqualTo(exp197a));
            Assert.That(exp197a, Is.EqualTo(exp197b));
            Assert.That(exp197a, Is.EqualTo(new Experience(197)));
            Assert.That(exp1a, Is.EqualTo(exp1a));
            Assert.That(exp1a, Is.EqualTo(exp1b));
            Assert.That(exp1a, Is.EqualTo(new Experience(1)));
            Assert.That(exp197a, Is.Not.EqualTo(exp1a));
            Assert.That(exp197a, Is.Not.EqualTo(obj));
        }

        [Test]
        public void TestGetHashCode()
        {
            var exp197 = new Experience(197);
            Assert.That(exp197.GetHashCode, Is.EqualTo(197.GetHashCode()));

            var exp1 = new Experience(1);
            Assert.That(exp1.GetHashCode, Is.EqualTo(1.GetHashCode()));
        }

        [Test]
        public void TestZero()
        {
            Assert.That(Experience.Zero.Value, Is.EqualTo(0));
            Assert.That(Experience.Zero, Is.EqualTo(new Experience(0)));
        }
    }
}
