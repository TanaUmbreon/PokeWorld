using PokeWorld.Core.Models;

namespace PokeWorld.Core.Test.Models;

[TestFixture]
public class BasePointExperienceTest
{
    [TestCase(StatDetail.HitPoint, 1)]
    [TestCase(StatDetail.Attack, 1)]
    [TestCase(StatDetail.Defense, 1)]
    [TestCase(StatDetail.SpecialAttack, 1)]
    [TestCase(StatDetail.SpecialDefense, 1)]
    [TestCase(StatDetail.Speed, 1)]
    [TestCase(StatDetail.HitPoint, int.MinValue)]
    [TestCase(StatDetail.HitPoint, 0)]
    [TestCase(StatDetail.HitPoint, int.MaxValue)]
    [TestCase((StatDetail)6, 0)]
    public void TestNew(StatDetail target, int value)
    {
        var exp = new BasePointExperience(target, value);
        Assert.That(exp.Target, Is.EqualTo(target));
        Assert.That(exp.Value, Is.EqualTo(value));
    }
}
