using PokeWorld.Core.Models;

namespace PokeWorld.Core.Test.Models;

[TestFixture]
public class BasePointTest
{
    [Test]
    public void TestZero()
    {
        Assert.That(BasePoint.Zero.Value, Is.Zero);
    }

    [TestCase(-1, 0, Description = "最小値を下回る場合はクランプされる")]
    [TestCase(0, 0, Description = "最小値は0")]
    [TestCase(197, 197)]
    [TestCase(252, 252, Description = "最大値は252")]
    [TestCase(253, 252, Description = "最大値を上回る場合はクランプされる")]
    public void TestNew(int inputValue, int expectedValue)
    {
        var bp = new BasePoint(inputValue);
        Assert.That(bp.Value, Is.EqualTo(expectedValue));
    }

    [TestCase(0, false)]
    [TestCase(251, false)]
    [TestCase(252, true)]
    [TestCase(253, true)]
    public void TestIsMax(int inputValue, bool expectedIsMax)
    {
        var bp = new BasePoint(inputValue);
        Assert.That(bp.IsMax(), Is.EqualTo(expectedIsMax));
    }

    [TestCase(0, 0, 0)]
    [TestCase(0, 2, 2)]
    [TestCase(0, 251, 251)]
    [TestCase(0, 252, 252)]
    [TestCase(0, 253, 252, Description = "最大値を上回る加算ではクランプされる")]
    [TestCase(197, 54, 251)]
    [TestCase(197, 55, 252)]
    [TestCase(197, 56, 252)]
    [TestCase(252, 0, 252)]
    [TestCase(252, 1, 252)]
    [TestCase(252, -3, 249, Description = "マイナスでの加算も可能(減算)")]
    [TestCase(252, -251, 1)]
    [TestCase(252, -252, 0)]
    [TestCase(252, -253, 0, Description = "最小値を下回る加算ではクランプされる")]
    [TestCase(0, int.MaxValue, 252)]
    [TestCase(1, int.MaxValue, 252, Description = "intの最大値を上回る加算でもオーバーフローは発生させずに最大値にする")]
    [TestCase(-1, int.MinValue, 0, Description = "コンストラクタの時点で基礎ポイントが最小値にクランプしているので、intの最小値を下回る加算はできない")]
    public void TestAdd(int initialValue, int addingValue, int expectedValue)
    {
        var bp1 = new BasePoint(initialValue);
        int bp1Value = bp1.Value;
        var bp2 = bp1.Add(addingValue);
        Assert.That(bp2.Value, Is.EqualTo(expectedValue));
        Assert.That(bp1.Value, Is.EqualTo(bp1Value)); // Addした側の値は不変
    }
}
