#pragma warning disable CS8618 // null 非許容のフィールドには、コンストラクターの終了時に null 以外の値が入っていなければなりません。Null 許容として宣言することをご検討ください。

using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using PokeWorld.Common;

namespace PokeWorld.Test.Common
{
    [TestFixture]
    public class KeyRecordCollectionTest
    {
        private record TestKeyRecord(string Key) : KeyRecord(Key) { }

        private const string Item0Key = "";
        private const string Item1Key = "BBB";
        private const string Item2Key = "A";
        private const string Item3Key = "C";
        private const string Item4Key = "AAA";

        private TestKeyRecord item0;
        private TestKeyRecord item1;
        private TestKeyRecord item2;
        private TestKeyRecord item3;
        private TestKeyRecord item4;

        private IEnumerable<TestKeyRecord> collection;

        [SetUp]
        public void SetUp()
        {
            item0 = new TestKeyRecord(Item0Key);
            item1 = new TestKeyRecord(Item1Key);
            item2 = new TestKeyRecord(Item2Key);
            item3 = new TestKeyRecord(Item3Key);
            item4 = new TestKeyRecord(Item4Key);
            collection = new[] { item0, item1, item2, item3, item4, };
        }

        #region .ctor(IEnumerable<T>)

        [Test(Description = "空のコレクションを指定するとエラーにならない。")]
        public void TestNew1()
        {
            IEnumerable<TestKeyRecord> collection = Array.Empty<TestKeyRecord>();
            Assert.That(() => { var c = new KeyRecordCollection<TestKeyRecord>(collection); }, Throws.Nothing);
        }

        [Test(Description = "重複したキーが含まれているコレクションを指定するとArgumentExceptionをスロー。")]
        public void TestNew2()
        {
            IEnumerable<TestKeyRecord> collection = new[]
            {
                new TestKeyRecord("A"),
                new TestKeyRecord("B"),
                new TestKeyRecord("AA"),
                new TestKeyRecord("C"),
                new TestKeyRecord("B"),
            };
            Assert.That(() => { var c = new KeyRecordCollection<TestKeyRecord>(collection); }, Throws.ArgumentException);
        }

        [Test(Description = "重複したキーが含まれないコレクションを指定するとエラーにならない。")]
        public void TestNew3()
        {
            Assert.That(() => { var c = new KeyRecordCollection<TestKeyRecord>(collection); }, Throws.Nothing);
        }

        #endregion

        #region this[string]

        [Test(Description = "コレクションに存在するキーを指定すると、それに対応するKeyRecordを返す。また、指定したキー名と対応するKeyRecordのキー名は同一。")]
        public void TestThis1()
        {
            var c = new KeyRecordCollection<TestKeyRecord>(collection);

            Assert.That(c[Item0Key], Is.EqualTo(item0));
            Assert.That(c[Item1Key], Is.EqualTo(item1));
            Assert.That(c[Item2Key], Is.EqualTo(item2));
            Assert.That(c[Item3Key], Is.EqualTo(item3));
            Assert.That(c[Item4Key], Is.EqualTo(item4));

            Assert.That(c[Item0Key].Key, Is.EqualTo(Item0Key));
            Assert.That(c[Item1Key].Key, Is.EqualTo(Item1Key));
            Assert.That(c[Item2Key].Key, Is.EqualTo(Item2Key));
            Assert.That(c[Item3Key].Key, Is.EqualTo(Item3Key));
            Assert.That(c[Item4Key].Key, Is.EqualTo(Item4Key));
        }

        [Test(Description = "コレクションに存在しないキーを指定するとIndexOutOfRangeExceptionをスロー。")]
        public void TestThis2()
        {
            var c = new KeyRecordCollection<TestKeyRecord>(collection);

            Assert.That(() => { TestKeyRecord r = c["197"]; }, Throws.TypeOf<IndexOutOfRangeException>());
        }

        #endregion
    }
}
