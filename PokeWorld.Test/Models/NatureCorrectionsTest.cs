using NUnit.Framework;
using PokeWorld.Models;

namespace PokeWorld.Test.Models
{
    [TestFixture]
    public class NatureCorrectionsTest
    {
        [Test]
        public void TestNew()
        {
            {
                var obj = new NatureCorrections(
                    attack: NatureCorrection.NoChange,
                    defense: NatureCorrection.NoChange,
                    spAttack: NatureCorrection.NoChange,
                    spDefense: NatureCorrection.NoChange,
                    speed: NatureCorrection.NoChange);

                Assert.That(obj.Attack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(obj.Defense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(obj.SpAttack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(obj.SpDefense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(obj.Speed, Is.EqualTo(NatureCorrection.NoChange));
            }
            {
                var obj = new NatureCorrections(
                    attack: NatureCorrection.Increased,
                    defense: NatureCorrection.Decreased,
                    spAttack: NatureCorrection.NoChange,
                    spDefense: NatureCorrection.Decreased,
                    speed: NatureCorrection.Increased);

                Assert.That(obj.Attack, Is.EqualTo(NatureCorrection.Increased));
                Assert.That(obj.Defense, Is.EqualTo(NatureCorrection.Decreased));
                Assert.That(obj.SpAttack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(obj.SpDefense, Is.EqualTo(NatureCorrection.Decreased));
                Assert.That(obj.Speed, Is.EqualTo(NatureCorrection.Increased));
            }
            {
                var obj = new NatureCorrections(
                    attack: NatureCorrection.Decreased,
                    defense: NatureCorrection.NoChange,
                    spAttack: NatureCorrection.Decreased,
                    spDefense: NatureCorrection.Increased,
                    speed: NatureCorrection.Increased);

                Assert.That(obj.Attack, Is.EqualTo(NatureCorrection.Decreased));
                Assert.That(obj.Defense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(obj.SpAttack, Is.EqualTo(NatureCorrection.Decreased));
                Assert.That(obj.SpDefense, Is.EqualTo(NatureCorrection.Increased));
                Assert.That(obj.Speed, Is.EqualTo(NatureCorrection.Increased));
            }
        }
    }
}
