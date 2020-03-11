﻿using System;
using System.Collections.Generic;
using NUnit.Framework;
using PokeWorld.Statistics;
using PokeWorld.Statistics.Generators;

namespace PokeWorld.Test.Statistics.Generators
{
    [TestFixture]
    public class FixedNatureGeneratorTest
    {
        [Test]
        public void TestNew()
        {
            Assert.That(() => new FixedNatureGenerator(Nature.Hardy), Throws.Nothing);
        }

        [Test]
        public void TestGenerate()
        {
            var gen = new FixedNatureGenerator(Nature.Hardy);
            Assert.That(gen.Generate(), Is.EqualTo(Nature.Hardy));

            var gen2 = new FixedNatureGenerator(Nature.Quirky);
            Assert.That(gen2.Generate(), Is.EqualTo(Nature.Quirky));
        }
    }
}
