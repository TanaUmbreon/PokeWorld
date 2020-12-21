#pragma warning disable CA1806 // メソッドの結果を無視しない
#pragma warning disable CS8618 // null 非許容のフィールドには、コンストラクターの終了時に null 以外の値が入っていなければなりません。Null 許容として宣言することをご検討ください。
#pragma warning disable CS8625 // null リテラルを null 非許容参照型に変換できません。

using System;
using NUnit.Framework;

namespace PokeWorld.Test.Helpers
{
    [TestFixture]
    public class TestableRandomizerTest
    {
        private NextValueController controller;
        private TestableRandomizer random;

        [SetUp]
        public void SetUp()
        {
            controller = new NextValueController();
            random = new TestableRandomizer(controller);
        }

        [Test]
        public void TestNew()
        {
            Assert.That(() => { new TestableRandomizer(controller); }, Throws.Nothing);
            Assert.That(() => { new TestableRandomizer(null); }, Throws.ArgumentNullException);
        }

        [Test]
        public void TestNext1()
        {
            controller.NextInt32Value = 1;
            Assert.That(random.Next(1, 197), Is.EqualTo(1));
            Assert.That(() => { random.Next(2, 197); }, Throws.InvalidOperationException);

            controller.NextInt32Value = 197;
            Assert.That(() => { random.Next(1, 197); }, Throws.InvalidOperationException);
            Assert.That(random.Next(1, 198), Is.EqualTo(197));
        }

        [Test]
        public void TestNext2()
        {
            controller.NextInt32Value = 0;
            Assert.That(random.Next(197), Is.EqualTo(0));

            controller.NextInt32Value = -1;
            Assert.That(() => { random.Next(197); }, Throws.InvalidOperationException);

            controller.NextInt32Value = 197;
            Assert.That(() => { random.Next(197); }, Throws.InvalidOperationException);
            Assert.That(random.Next(198), Is.EqualTo(197));
        }

        [Test]
        public void TestNextBoolean()
        {
            controller.NextInt32Value = -1;
            Assert.That(() => { random.NextBoolean(); }, Throws.InvalidOperationException);

            controller.NextInt32Value = 0;
            Assert.That(random.NextBoolean(), Is.False);

            controller.NextInt32Value = 1;
            Assert.That(random.NextBoolean(), Is.True);

            controller.NextInt32Value = 2;
            Assert.That(() => { random.NextBoolean(); }, Throws.InvalidOperationException);
        }

        [Test]
        public void TestSelectOne()
        {
            Assert.That(() => { random.SelectOne<object>(null); }, Throws.ArgumentNullException);
            Assert.That(() => { random.SelectOne(Array.Empty<object>()); }, Throws.ArgumentException);

            {
                var intList = new[] { 197, 1, 258, 722 };

                controller.NextInt32Value = -1;
                Assert.That(() => { random.SelectOne(intList); }, Throws.InvalidOperationException);

                controller.NextInt32Value = 0;
                Assert.That(random.SelectOne(intList), Is.EqualTo(197));

                controller.NextInt32Value = 3;
                Assert.That(random.SelectOne(intList), Is.EqualTo(722));

                controller.NextInt32Value = 4;
                Assert.That(() => { random.SelectOne(intList); }, Throws.InvalidOperationException);
            }

            {
                var item0 = new Action(() => { });
                var item1 = new Action(() => { });
                var item2 = new Action(() => { });
                var objectList = new[] { item0, item1, item2 };

                controller.NextInt32Value = 0;
                Assert.That(random.SelectOne(objectList), Is.EqualTo(item0));
                Assert.That(random.SelectOne(objectList), Is.Not.EqualTo(item1));
                Assert.That(random.SelectOne(objectList), Is.Not.EqualTo(item2));

                controller.NextInt32Value = 2;
                Assert.That(random.SelectOne(objectList), Is.EqualTo(item2));
            }
        }
    }
}
