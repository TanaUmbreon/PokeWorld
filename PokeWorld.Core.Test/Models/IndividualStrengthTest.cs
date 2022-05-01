using PokeWorld.Core.Models;

namespace PokeWorld.Core.Test.Models;

[TestFixture]
public class IndividualStrengthTest
{
    [TestCase(-1, false, 0, false, Description = "最小値を下回る場合はクランプされる")]
    [TestCase(-1, true, 0, true)]
    [TestCase(0, false, 0, false, Description = "最小値は0")]
    [TestCase(0, true, 0, true)]
    [TestCase(15, false, 15, false)]
    [TestCase(15, true, 15, true)]
    [TestCase(31, false, 31, false, Description = "最大値は0")]
    [TestCase(31, true, 31, true)]
    [TestCase(32, false, 31, false, Description = "最大値を上回る場合はクランプされる")]
    [TestCase(32, true, 31, true)]
    public void TestNew(int inputOriginalValue, bool inputHasTrainedHyper, int expectedOriginalValue, bool expectedHasTrainedHyper)
    {
        var individual = new IndividualStrength(inputOriginalValue, inputHasTrainedHyper);
        Assert.That(individual.OriginalValue, Is.EqualTo(expectedOriginalValue));
        Assert.That(individual.HasTrainedHyper, Is.EqualTo(expectedHasTrainedHyper));
    }

    [TestCase(-1, 0)]
    [TestCase(0, 0)]
    [TestCase(15, 15)]
    [TestCase(31, 31)]
    [TestCase(32, 31)]
    public void TestNew_DefaultArgument(int inputOriginalValue, int expectedOriginalValue)
    {
        var individual = new IndividualStrength(inputOriginalValue);
        Assert.That(individual.OriginalValue, Is.EqualTo(expectedOriginalValue));
        Assert.That(individual.HasTrainedHyper, Is.False);
    }

    [TestCase(0, false, false)]
    [TestCase(30, false, false)]
    [TestCase(31, false, true)]
    [TestCase(0, true, false, Description = "鍛えていても本来の生まれつきの強さが上限値でない場合はtrueにならない")]
    [TestCase(30, true, false)]
    [TestCase(31, true, true)]
    public void TestIsMax(int inputOriginalValue, bool inputHasTrainedHyper, bool expectedIsMax)
    {
        var individual = new IndividualStrength(inputOriginalValue, inputHasTrainedHyper);
        Assert.That(individual.IsMax(), Is.EqualTo(expectedIsMax));
    }

    [TestCase(0, false, 0, Description = "鍛えていない、かつ下限値を下回る場合は下限値を返す")]
    [TestCase(30, false, 30)]
    [TestCase(31, false, 31, Description = "鍛えていない、かつ上限値を上回る場合は上限値を返す")]
    [TestCase(0, true, 31, Description = "鍛えている場合は無条件で上限値を返す")]
    [TestCase(30, true, 31)]
    [TestCase(31, true, 31)]
    public void TestGetActualValue(int inputOriginalValue, bool inputHasTrainedHyper, int expectedActualValue)
    {
        var individual = new IndividualStrength(inputOriginalValue, inputHasTrainedHyper);
        Assert.That(individual.GetActualValue(), Is.EqualTo(expectedActualValue));
    }

    [TestCase(-1, false, IndividualStrengthJudge.NoGood)]
    [TestCase(0, false, IndividualStrengthJudge.NoGood)]
    [TestCase(1, false, IndividualStrengthJudge.Decent)]
    [TestCase(15, false, IndividualStrengthJudge.Decent)]
    [TestCase(16, false, IndividualStrengthJudge.PrettyGood)]
    [TestCase(25, false, IndividualStrengthJudge.PrettyGood)]
    [TestCase(26, false, IndividualStrengthJudge.VeryGood)]
    [TestCase(29, false, IndividualStrengthJudge.VeryGood)]
    [TestCase(30, false, IndividualStrengthJudge.Fantastic)]
    [TestCase(31, false, IndividualStrengthJudge.Best)]
    [TestCase(32, false, IndividualStrengthJudge.Best)]
    [TestCase(-1, true, IndividualStrengthJudge.NoGood, Description = "鍛えていても本来の個体値で判定を返す")]
    [TestCase(0, true, IndividualStrengthJudge.NoGood)]
    [TestCase(1, true, IndividualStrengthJudge.Decent)]
    [TestCase(15, true, IndividualStrengthJudge.Decent)]
    [TestCase(16, true, IndividualStrengthJudge.PrettyGood)]
    [TestCase(25, true, IndividualStrengthJudge.PrettyGood)]
    [TestCase(26, true, IndividualStrengthJudge.VeryGood)]
    [TestCase(29, true, IndividualStrengthJudge.VeryGood)]
    [TestCase(30, true, IndividualStrengthJudge.Fantastic)]
    [TestCase(31, true, IndividualStrengthJudge.Best)]
    [TestCase(32, true, IndividualStrengthJudge.Best)]
    public void TestJudge(int originalValue, bool hyperTrained, IndividualStrengthJudge expectedValue)
    {
        var individual = new IndividualStrength(originalValue, hyperTrained);
        Assert.That(individual.GetJudge(), Is.EqualTo(expectedValue));
    }

    [Test]
    public void TestTrainHyper()
    {
        var before = new IndividualStrength(5, false);
        Assert.That(before.HasTrainedHyper, Is.False);
        Assert.That(before.OriginalValue, Is.EqualTo(5));
        Assert.That(before.GetActualValue(), Is.EqualTo(5));

        IndividualStrength after = before.TrainHyper();
        Assert.That(after.HasTrainedHyper, Is.True);
        Assert.That(after.OriginalValue, Is.EqualTo(5));
        Assert.That(after.GetActualValue(), Is.EqualTo(31));

        Assert.That(before.HasTrainedHyper, Is.False);
        Assert.That(before.OriginalValue, Is.EqualTo(5));
        Assert.That(before.GetActualValue(), Is.EqualTo(5));
    }
}
