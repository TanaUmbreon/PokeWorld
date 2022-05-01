using PokeWorld.Core.Models;

namespace PokeWorld.Core.Test.Models;

[TestFixture]
public class LevelTest
{
    [TestCase(0, 1, Description = "最小値を下回る場合はクランプされる")]
    [TestCase(1, 1, Description = "最小値は1")]
    [TestCase(50, 50)]
    [TestCase(100, 100, Description = "最大値は100")]
    [TestCase(101, 100, Description = "最大値を上回る場合はクランプされる")]
    public void TestNew(int inputValue, int expectedValue)
    {
        var lv = new Level(inputValue);
        Assert.That(lv.Value, Is.EqualTo(expectedValue));
    }

    [TestCase(1, false)]
    [TestCase(99, false)]
    [TestCase(100, true)]
    [TestCase(101, true)]
    public void TestIsMax(int inputValue, bool expectedValue)
    {
        var lv = new Level(inputValue);
        Assert.That(lv.IsMax(), Is.EqualTo(expectedValue));
    }

    [TestCase(1, 0, 1)]
    [TestCase(1, 2, 3)]
    [TestCase(1, 98, 99)]
    [TestCase(1, 99, 100)]
    [TestCase(1, 100, 100, Description = "最大値を上回る加算ではクランプされる")]
    [TestCase(50, 49, 99)]
    [TestCase(50, 50, 100)]
    [TestCase(50, 51, 100)]
    [TestCase(100, 0, 100)]
    [TestCase(100, 1, 100)]
    [TestCase(100, -3, 97, Description = "マイナスでの加算も可能(減算)")]
    [TestCase(100, -98, 2)]
    [TestCase(100, -99, 1)]
    [TestCase(100, -100, 1, Description = "最小値を下回る加算ではクランプされる")]
    [TestCase(1, int.MaxValue - 1, 100)]
    [TestCase(1, int.MaxValue, 100, Description = "intの最大値を上回る加算でもオーバーフローは発生させずに最大値にする")]
    [TestCase(-1, int.MinValue, 1, Description = "コンストラクタの時点で値が最小値にクランプしているので、intの最小値を下回る加算はできない")]
    public void TestAdd(int initialValue, int addingValue, int expectedValue)
    {
        var initialLv = new Level(initialValue);
        int initialLvValue = initialLv.Value;
        var addedLv = initialLv.Add(addingValue);
        Assert.That(addedLv.Value, Is.EqualTo(expectedValue));
        Assert.That(initialLv.Value, Is.EqualTo(initialLvValue)); // Addした側の値は不変
    }
}
