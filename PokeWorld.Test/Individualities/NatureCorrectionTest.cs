using NUnit.Framework;
using PokeWorld.Individualities;

namespace PokeWorld.Test.Individualities
{
    [TestFixture]
    public class NatureCorrectionTest
    {
        [Test]
        public void TestEnumerationMember()
        {
            // Nameプロパティは表示に使用しないのでテストしない
            {
                NatureCorrection member = NatureCorrection.NoChange;
                Assert.That(member.Id, Is.EqualTo(0));
                Assert.That(member.Rate, Is.EqualTo(1.0));
            }
            {
                NatureCorrection member = NatureCorrection.Increased;
                Assert.That(member.Id, Is.EqualTo(1));
                Assert.That(member.Rate, Is.EqualTo(1.1));
            }
            {
                NatureCorrection member = NatureCorrection.Decreased;
                Assert.That(member.Id, Is.EqualTo(2));
                Assert.That(member.Rate, Is.EqualTo(0.9));
            }
        }
    }
}
