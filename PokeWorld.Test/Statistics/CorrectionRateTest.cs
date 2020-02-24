using NUnit.Framework;
using PokeWorld.Statistics;

namespace PokeWorld.Test.Statistics
{
    [TestFixture]
    public class CorrectionRateTest
    {
        [Test]
        public void TestEnumerationMember()
        {
            // Nameプロパティは表示に使用しないのでテストしない
            {
                CorrectionRate member = CorrectionRate.NoChange;
                Assert.That(member.Id, Is.EqualTo(0));
                Assert.That(member.Rate, Is.EqualTo(1.0));
            }
            {
                CorrectionRate member = CorrectionRate.Increased;
                Assert.That(member.Id, Is.EqualTo(1));
                Assert.That(member.Rate, Is.EqualTo(1.1));
            }
            {
                CorrectionRate member = CorrectionRate.Decreased;
                Assert.That(member.Id, Is.EqualTo(2));
                Assert.That(member.Rate, Is.EqualTo(0.9));
            }
        }
    }
}
