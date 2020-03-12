using NUnit.Framework;
using PokeWorld.Individualities;
using PokeWorld.Individualities.Generators;

namespace PokeWorld.Test
{
    [TestFixture]
    public class PokemonTest
    {
        [Test]
        public void Test()
        {
            // ダネちゃんLv.1爆誕！
            var fushiLv1 = new Pokemon(Species.Bulbasaur, new Level(1), RandomNatureGenerator.Instance);
            Assert.That(fushiLv1.Level.Value, Is.EqualTo(1));
            Assert.That(fushiLv1.TotalExp.Value, Is.EqualTo(0));
            Assert.That(fushiLv1.RequiredExpToNextLevel.Value, Is.EqualTo(9));

            // ダネちゃんLv.2爆誕！
            var fushiLv2 = new Pokemon(Species.Bulbasaur, new Level(2), RandomNatureGenerator.Instance);
            Assert.That(fushiLv2.Level.Value, Is.EqualTo(2));
            Assert.That(fushiLv2.TotalExp.Value, Is.EqualTo(9));
            Assert.That(fushiLv2.RequiredExpToNextLevel.Value, Is.EqualTo(48));

            // ダネちゃんLv.99爆誕！
            var fushiLv99 = new Pokemon(Species.Bulbasaur, new Level(99), RandomNatureGenerator.Instance);
            Assert.That(fushiLv99.Level.Value, Is.EqualTo(99));
            Assert.That(fushiLv99.TotalExp.Value, Is.EqualTo(1_027_103));
            Assert.That(fushiLv99.RequiredExpToNextLevel.Value, Is.EqualTo(32_757));

            // ダネちゃんLv.100爆誕！
            var fushiLv100 = new Pokemon(Species.Bulbasaur, new Level(100), RandomNatureGenerator.Instance);
            Assert.That(fushiLv100.Level.Value, Is.EqualTo(100));
            Assert.That(fushiLv100.TotalExp.Value, Is.EqualTo(1_059_860));
            Assert.That(fushiLv100.RequiredExpToNextLevel.Value, Is.EqualTo(0));
        }
    }
}
