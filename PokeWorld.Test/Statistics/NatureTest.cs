using NUnit.Framework;
using PokeWorld.Statistics;

namespace PokeWorld.Test.Statistics
{
    [TestFixture]
    public class NatureTest
    {
        [Test]
        public void TestEnumerationMember()
        {
            {
                Nature member = Nature.Hardy;
                Assert.That(member.Id, Is.EqualTo(0));
                Assert.That(member.Name, Is.EqualTo("がんばりや"));
                Assert.That(member.Attack, Is.EqualTo(CorrectionRate.NoChange));
                Assert.That(member.Defence, Is.EqualTo(CorrectionRate.NoChange));
                Assert.That(member.SpAttack, Is.EqualTo(CorrectionRate.NoChange));
                Assert.That(member.SpDefence, Is.EqualTo(CorrectionRate.NoChange));
                Assert.That(member.Speed, Is.EqualTo(CorrectionRate.NoChange));
            }
        }
    }
}
