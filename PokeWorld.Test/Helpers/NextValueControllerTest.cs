#pragma warning disable CA1806 // メソッドの結果を無視しない

using NUnit.Framework;

namespace PokeWorld.Test.Helpers
{
    public class NextValueControllerTest
    {
        [Test]
        public void TestNew()
        {
            Assert.That(() => { new NextValueController(); }, Throws.Nothing);
        }

        [Test]
        public void TestNextInt32Value()
        {
            var c = new NextValueController();
            Assert.That(c.NextInt32Value, Is.Zero);

            c.NextInt32Value = 197;
            Assert.That(c.NextInt32Value, Is.EqualTo(197));

            c.NextInt32Value = int.MaxValue;
            Assert.That(c.NextInt32Value, Is.EqualTo(2147483647));

            c.NextInt32Value = int.MinValue;
            Assert.That(c.NextInt32Value, Is.EqualTo(-2147483648));
        }
    }
}
