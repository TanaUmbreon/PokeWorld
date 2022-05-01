#nullable disable

using PokeWorld.Core.Models;

namespace PokeWorld.Core.Test.Models;

[TestFixture]
public class IndividualStrengthSetTest
{
    [Test]
    public void TestNew1()
    {
        var hp = new IndividualStrength(0);
        var attack = new IndividualStrength(1);
        var defence = new IndividualStrength(2);
        var spAttack = new IndividualStrength(4);
        var spDefense = new IndividualStrength(8);
        var speed = new IndividualStrength(16);
        var individual = new IndividualStrengthSet(hp, attack, defence, spAttack, spDefense, speed);

        Assert.That(individual.HitPoint, Is.EqualTo(hp));
        Assert.That(individual.Attack, Is.EqualTo(attack));
        Assert.That(individual.Defense, Is.EqualTo(defence));
        Assert.That(individual.SpecialAttack, Is.EqualTo(spAttack));
        Assert.That(individual.SpecialDefense, Is.EqualTo(spDefense));
        Assert.That(individual.Speed, Is.EqualTo(speed));
    }

    public static IEnumerable<TestCaseData> TestNew1_NullCaseSource
    {
        get
        {
            yield return new TestCaseData(null, new IndividualStrength(0), new IndividualStrength(0), new IndividualStrength(0), new IndividualStrength(0), new IndividualStrength(0));
            yield return new TestCaseData(new IndividualStrength(0), null, new IndividualStrength(0), new IndividualStrength(0), new IndividualStrength(0), new IndividualStrength(0));
            yield return new TestCaseData(new IndividualStrength(0), new IndividualStrength(0), null, new IndividualStrength(0), new IndividualStrength(0), new IndividualStrength(0));
            yield return new TestCaseData(new IndividualStrength(0), new IndividualStrength(0), new IndividualStrength(0), null, new IndividualStrength(0), new IndividualStrength(0));
            yield return new TestCaseData(new IndividualStrength(0), new IndividualStrength(0), new IndividualStrength(0), new IndividualStrength(0), null, new IndividualStrength(0));
            yield return new TestCaseData(new IndividualStrength(0), new IndividualStrength(0), new IndividualStrength(0), new IndividualStrength(0), new IndividualStrength(0), null);
        }
    }

    [TestCaseSource(nameof(TestNew1_NullCaseSource))]
    public void TestNew1_NullCase(
        IndividualStrength hitPoint,
        IndividualStrength attack,
        IndividualStrength defence,
        IndividualStrength specialAttack,
        IndividualStrength specialDefense,
        IndividualStrength speed)
    {
        Assert.That(() =>
        {
            _ = new IndividualStrengthSet(hitPoint, attack, defence, specialAttack, specialDefense, speed);
        }, Throws.ArgumentNullException);
    }

    [Test]
    public void TestNew2()
    {
        var individual = new IndividualStrengthSet(0, 1, 2, 4, 8, 16);

        Assert.That(individual.HitPoint.OriginalValue, Is.EqualTo(0));
        Assert.That(individual.Attack.OriginalValue, Is.EqualTo(1));
        Assert.That(individual.Defense.OriginalValue, Is.EqualTo(2));
        Assert.That(individual.SpecialAttack.OriginalValue, Is.EqualTo(4));
        Assert.That(individual.SpecialDefense.OriginalValue, Is.EqualTo(8));
        Assert.That(individual.Speed.OriginalValue, Is.EqualTo(16));

        Assert.That(individual.HitPoint.HasTrainedHyper, Is.False);
        Assert.That(individual.Attack.HasTrainedHyper, Is.False);
        Assert.That(individual.Defense.HasTrainedHyper, Is.False);
        Assert.That(individual.SpecialAttack.HasTrainedHyper, Is.False);
        Assert.That(individual.SpecialDefense.HasTrainedHyper, Is.False);
        Assert.That(individual.Speed.HasTrainedHyper, Is.False);
    }
}
