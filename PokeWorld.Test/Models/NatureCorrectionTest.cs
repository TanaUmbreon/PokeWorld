using NUnit.Framework;
using PokeWorld.Models;

namespace PokeWorld.Test.Models
{
    [TestFixture]
    public class NatureCorrectionTest
    {
        [Test]
        public void TestEnumerationMember()
        {
            {
                NatureCorrection member = NatureCorrection.NoChange;
                Assert.That(member.Id, Is.EqualTo(0));
                Assert.That(member.Key, Is.EqualTo("NoChange"));
                Assert.That(member.Rate, Is.EqualTo(1.0));
            }
            {
                NatureCorrection member = NatureCorrection.Increased;
                Assert.That(member.Id, Is.EqualTo(1));
                Assert.That(member.Key, Is.EqualTo("Increased"));
                Assert.That(member.Rate, Is.EqualTo(1.1));
            }
            {
                NatureCorrection member = NatureCorrection.Decreased;
                Assert.That(member.Id, Is.EqualTo(2));
                Assert.That(member.Key, Is.EqualTo("Decreased"));
                Assert.That(member.Rate, Is.EqualTo(0.9));
            }
        }
    }
}
