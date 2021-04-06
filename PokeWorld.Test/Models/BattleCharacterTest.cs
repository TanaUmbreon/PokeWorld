using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Moq;
using PokeWorld.Models;
using PokeWorld.Models.Static;

namespace PokeWorld.Test.Models
{
    [TestFixture]
    public class BattleCharacterTest
    {
        private IBattleCharacterGenerator CreateGenerator()
        {
            var mock = new Mock<IBattleCharacterGenerator>();

            mock.Setup(g => g.GetSpecies()).Returns(
                new SpeciesStaticInfo(
                    key: "Bulbasaur",
                    pokedexNumber: new PokedexNumberStaticInfo(national: 1)
                    ));
            mock.Setup(g => g.GetLevel()).Returns(5);

            return mock.Object;
        }

        [Test]
        public void TestNew()
        {
            var character = new BattleCharacter(CreateGenerator());

            Assert.That(character.Species.Key, Is.EqualTo("Bulbasaur"));

            Assert.That(character.Species.PokedexNumber.National, Is.EqualTo(1));
            Assert.That(character.Species.GetNationalPokedexNumber(), Is.EqualTo(1));

            Assert.That(character.Species.BaseStats.HitPoints, Is.EqualTo(20));
            Assert.That(character.Species.BaseStats.Attack, Is.EqualTo(10));
            Assert.That(character.Species.BaseStats.Defense, Is.EqualTo(11));
            Assert.That(character.Species.BaseStats.SpecialAttack, Is.EqualTo(14));
            Assert.That(character.Species.BaseStats.SpecialDefense, Is.EqualTo(13));
            Assert.That(character.Species.BaseStats.Speed, Is.EqualTo(12));

            Assert.That(character.Level, Is.EqualTo(5));

            Assert.That(character.Stat.HitPoints, Is.EqualTo(20));
            Assert.That(character.Stat.Attack, Is.EqualTo(10));
            Assert.That(character.Stat.Defense, Is.EqualTo(11));
            Assert.That(character.Stat.SpecialAttack, Is.EqualTo(14));
            Assert.That(character.Stat.SpecialDefense, Is.EqualTo(13));
            Assert.That(character.Stat.Speed, Is.EqualTo(12));

            Assert.That(character.IndividualStrengths.HitPoints, Is.EqualTo(6));
            Assert.That(character.IndividualStrengths.Attack, Is.EqualTo(11));
            Assert.That(character.IndividualStrengths.Defense, Is.EqualTo(16));
            Assert.That(character.IndividualStrengths.SpecialAttack, Is.EqualTo(21));
            Assert.That(character.IndividualStrengths.SpecialDefense, Is.EqualTo(26));
            Assert.That(character.IndividualStrengths.Speed, Is.EqualTo(31));

            Assert.That(character.BasePoints.HitPoints, Is.EqualTo(80));
            Assert.That(character.BasePoints.Attack, Is.EqualTo(8));
            Assert.That(character.BasePoints.Defense, Is.EqualTo(24));
            Assert.That(character.BasePoints.SpecialAttack, Is.EqualTo(116));
            Assert.That(character.BasePoints.SpecialDefense, Is.EqualTo(16));
            Assert.That(character.BasePoints.Speed, Is.EqualTo(76));

            Assert.That(character.Nature.Key, Is.EqualTo("Quirky"));
        }
    }
}
