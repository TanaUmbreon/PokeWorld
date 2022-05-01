#nullable disable


namespace PokeWorld.Core.Test.Helpers;

[TestFixture]
public class TestableRandomizerTest
{
    private NextValueController _controller;
    private TestableRandomizer _random;

    [SetUp]
    public void SetUp()
    {
        _controller = new NextValueController();
        _random = new TestableRandomizer(_controller);
    }

    [Test]
    public void TestNew()
    {
        Assert.That(() => { _ = new TestableRandomizer(_controller); }, Throws.Nothing);
        Assert.That(() => { _ = new TestableRandomizer(null); }, Throws.ArgumentNullException);
    }

    [Test]
    public void TestNext1()
    {
        _controller.NextInt32Value = 1;
        Assert.That(_random.NextInt(1, 197), Is.EqualTo(1));
        Assert.That(() => { _random.NextInt(2, 197); }, Throws.InvalidOperationException);

        _controller.NextInt32Value = 197;
        Assert.That(() => { _random.NextInt(1, 197); }, Throws.InvalidOperationException);
        Assert.That(_random.NextInt(1, 198), Is.EqualTo(197));
    }

    [Test]
    public void TestNext2()
    {
        _controller.NextInt32Value = 0;
        Assert.That(_random.NextInt(197), Is.EqualTo(0));

        _controller.NextInt32Value = -1;
        Assert.That(() => { _random.NextInt(197); }, Throws.InvalidOperationException);

        _controller.NextInt32Value = 197;
        Assert.That(() => { _random.NextInt(197); }, Throws.InvalidOperationException);
        Assert.That(_random.NextInt(198), Is.EqualTo(197));
    }

    [Test]
    public void TestNextBoolean()
    {
        _controller.NextInt32Value = -1;
        Assert.That(() => { _random.NextBool(); }, Throws.InvalidOperationException);

        _controller.NextInt32Value = 0;
        Assert.That(_random.NextBool(), Is.False);

        _controller.NextInt32Value = 1;
        Assert.That(_random.NextBool(), Is.True);

        _controller.NextInt32Value = 2;
        Assert.That(() => { _random.NextBool(); }, Throws.InvalidOperationException);
    }

    [Test]
    public void TestSelectOne()
    {
        Assert.That(() => { _random.SelectOne<object>(null); }, Throws.ArgumentNullException);
        Assert.That(() => { _random.SelectOne(Array.Empty<object>()); }, Throws.ArgumentException);

        {
            var intList = new[] { 197, 1, 258, 722 };

            _controller.NextInt32Value = -1;
            Assert.That(() => { _random.SelectOne(intList); }, Throws.InvalidOperationException);

            _controller.NextInt32Value = 0;
            Assert.That(_random.SelectOne(intList), Is.EqualTo(197));

            _controller.NextInt32Value = 3;
            Assert.That(_random.SelectOne(intList), Is.EqualTo(722));

            _controller.NextInt32Value = 4;
            Assert.That(() => { _random.SelectOne(intList); }, Throws.InvalidOperationException);
        }

        {
            var item0 = new Action(() => { });
            var item1 = new Action(() => { });
            var item2 = new Action(() => { });
            var objectList = new[] { item0, item1, item2 };

            _controller.NextInt32Value = 0;
            Assert.That(_random.SelectOne(objectList), Is.EqualTo(item0));
            Assert.That(_random.SelectOne(objectList), Is.Not.EqualTo(item1));
            Assert.That(_random.SelectOne(objectList), Is.Not.EqualTo(item2));

            _controller.NextInt32Value = 2;
            Assert.That(_random.SelectOne(objectList), Is.EqualTo(item2));
        }
    }
}
