using PokeWorld.Core.Helpers;

namespace PokeWorld.Core.Test.Helpers;

[TestFixture]
public class ValueRangeTest
{
    [TestCase(0, 0)]
    [TestCase(int.MinValue, int.MinValue)]
    [TestCase(int.MinValue, int.MaxValue)]
    [TestCase(int.MaxValue, int.MaxValue)]
    public void TestNew(int min, int max)
    {
        var range = new ValueRange(min, max);
        Assert.That(range.Min, Is.EqualTo(min));
        Assert.That(range.Max, Is.EqualTo(max));
    }

    [TestCase(0, -1)]
    [TestCase(int.MinValue + 1, int.MinValue)]
    [TestCase(int.MaxValue, int.MaxValue - 1)]
    public void TestNew_ThrowsArgumentException(int min, int max)
    {
        Assert.That(() => new ValueRange(min, max), Throws.ArgumentException);
    }

    [TestCase(0, 0, 0, 0)]
    [TestCase(0, 0, -1, 0)]
    [TestCase(0, 0, 1, 0)]
    [TestCase(-5, 10, -6, -5)]
    [TestCase(-5, 10, -5, -5)]
    [TestCase(-5, 10, -4, -4)]
    [TestCase(-5, 10, 9, 9)]
    [TestCase(-5, 10, 10, 10)]
    [TestCase(-5, 10, 11, 10)]
    [TestCase(int.MinValue, 0, int.MinValue, int.MinValue)]
    [TestCase(int.MinValue, 0, int.MinValue + 1, int.MinValue + 1)]
    [TestCase(int.MinValue, 0, int.MaxValue, 0)]
    [TestCase(0, int.MaxValue, int.MinValue, 0)]
    [TestCase(0, int.MaxValue, int.MaxValue - 1, int.MaxValue - 1)]
    [TestCase(0, int.MaxValue, int.MaxValue, int.MaxValue)]
    public void TestClamp(int min, int max, int clampingValue, int clampedValue)
    {
        var range = new ValueRange(min, max);
        Assert.That(range.Clamp(clampingValue), Is.EqualTo(clampedValue));
    }

    [TestCase(-19, 7, -20, false)]
    [TestCase(-19, 7, -19, true)]
    [TestCase(-19, 7, -18, false)]
    [TestCase(-19, 7, 6, false)]
    [TestCase(-19, 7, 7, false)]
    [TestCase(-19, 7, 8, false)]
    [TestCase(197, 197, 196, false)]
    [TestCase(197, 197, 197, true)]
    [TestCase(197, 197, 198, false)]
    public void TestIsMin(int min, int max, int value, bool expectedResult)
    {
        var range = new ValueRange(min, max);
        Assert.That(range.IsMin(value), Is.EqualTo(expectedResult));
    }
}
