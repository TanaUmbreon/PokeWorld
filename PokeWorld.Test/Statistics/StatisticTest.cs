using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using PokeWorld.Statistics;

namespace PokeWorld.Test.Statistics
{
    [TestFixture]
    public class StatisticTest
    {
        [Test]
        public void Test()
        {
            var fushiLv1 = new Statistic(Species.Bulbasaur, new Level(1));
            Assert.That(fushiLv1.Level.Value, Is.EqualTo(1));
            Assert.That(fushiLv1.TotalExp.Value, Is.EqualTo(0));
            Assert.That(fushiLv1.RequiredExpToNextLevel.Value, Is.EqualTo(9));

            var fushiLv2 = new Statistic(Species.Bulbasaur, new Level(2));
            Assert.That(fushiLv2.Level.Value, Is.EqualTo(2));
            Assert.That(fushiLv2.TotalExp.Value, Is.EqualTo(9));
            Assert.That(fushiLv2.RequiredExpToNextLevel.Value, Is.EqualTo(48));

            var fushiLv99 = new Statistic(Species.Bulbasaur, new Level(99));
            Assert.That(fushiLv99.Level.Value, Is.EqualTo(99));
            Assert.That(fushiLv99.TotalExp.Value, Is.EqualTo(1_027_103));
            Assert.That(fushiLv99.RequiredExpToNextLevel.Value, Is.EqualTo(32_757));

            var fushiLv100 = new Statistic(Species.Bulbasaur, new Level(100));
            Assert.That(fushiLv100.Level.Value, Is.EqualTo(100));
            Assert.That(fushiLv100.TotalExp.Value, Is.EqualTo(1_059_860));
            Assert.That(fushiLv100.RequiredExpToNextLevel.Value, Is.EqualTo(0));
        }
    }
}
