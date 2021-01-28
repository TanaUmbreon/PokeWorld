using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PokeWorld.Common;

namespace PokeWorld.Test.Common
{
    [TestFixture]
    public class EnumerationTest
    {
        private class DummyEnumerationA : Enumeration
        {
            public DummyEnumerationA(int id, string key) : base(id, key) { }
        }

        private class DummyEnumerationB : Enumeration
        {
            public DummyEnumerationB(int id, string key) : base(id, key) { }
        }

        [Test]
        public void TestNew()
        {
            {
                Enumeration obj = new DummyEnumerationA(0, "Key0");
                Assert.That(obj.Id, Is.EqualTo(0));
                Assert.That(obj.Key, Is.EqualTo("Key0"));
            }
            {
                Enumeration obj = new DummyEnumerationA(1, "Key1");
                Assert.That(obj.Id, Is.EqualTo(1));
                Assert.That(obj.Key, Is.EqualTo("Key1"));
            }
        }

        [Test]
        public void TestGetAll()
        {
            var fields = Enumeration.GetAll<Enumeration>();
            Assert.That(fields, Is.Empty);
        }

        [Test]
        public void TestToString()
        {
            {
                Enumeration obj = new DummyEnumerationA(0, "Key0");
                Assert.That(obj.ToString(), Is.EqualTo("Key0"));
            }
            {
                Enumeration obj = new DummyEnumerationA(1, "Key1");
                Assert.That(obj.ToString(), Is.EqualTo("Key1"));
            }
        }

        [Test]
        public void TestEquals()
        {
            Enumeration objA0 = new DummyEnumerationA(0, "Key0");
            Enumeration objA1 = new DummyEnumerationA(1, "Key1");
            Enumeration objB0 = new DummyEnumerationB(objA0.Id, objA0.Key);

            Assert.That(objA0.Equals(objA0.Id), Is.False);
            Assert.That(objA0.Equals(objA0.Key), Is.False);
            Assert.That(objA0.Equals(objB0), Is.False);
            Assert.That(objA0.Equals(null), Is.False);

            Assert.That(objA1.Equals(objA1), Is.True);
            Assert.That(objA1.Equals(objA0), Is.False);
        }

        [Test]
        public void TestGetHashCode()
        {
            {
                Enumeration obj = new DummyEnumerationA(0, "Key0");
                Assert.That(obj.GetHashCode(), Is.EqualTo(0.GetHashCode()));
            }
            {
                Enumeration obj = new DummyEnumerationA(1, "Key1");
                Assert.That(obj.GetHashCode(), Is.EqualTo(1.GetHashCode()));
            }
        }

        [Test]
        public void TestEqualsOperator()
        {
            Enumeration objA0 = new DummyEnumerationA(0, "Key0");
            Enumeration objA1 = new DummyEnumerationA(1, "Key1");
            Enumeration objB0 = new DummyEnumerationB(objA0.Id, objA0.Key);
            Enumeration? objNull = null;

#pragma warning disable CS8604 // Null 参照引数の可能性があります。
            Assert.That(objA0 == objA1, Is.False);
            Assert.That(objA0 == objB0, Is.False);
            Assert.That(objA0 == objNull, Is.False);
            Assert.That(objA1 == objB0, Is.False);
            Assert.That(objA1 == objNull, Is.False);
            Assert.That(objB0 == objNull, Is.False);
#pragma warning disable CS1718 // 同じ変数と比較されました
            Assert.That(objA0 == objA0, Is.True);
            Assert.That(objA1 == objA1, Is.True);
            Assert.That(objB0 == objB0, Is.True);
            Assert.That(objNull == objNull, Is.True);
#pragma warning restore CS1718 // 同じ変数と比較されました
#pragma warning restore CS8604 // Null 参照引数の可能性があります。
        }

        [Test]
        public void TestNotEqualsOperator()
        {
            Enumeration objA0 = new DummyEnumerationA(0, "Key0");
            Enumeration objA1 = new DummyEnumerationA(1, "Key1");
            Enumeration objB0 = new DummyEnumerationB(objA0.Id, objA0.Key);
            Enumeration? objNull = null;

#pragma warning disable CS8604 // Null 参照引数の可能性があります。
            Assert.That(objA0 != objA1, Is.True);
            Assert.That(objA0 != objB0, Is.True);
            Assert.That(objA0 != objNull, Is.True);
            Assert.That(objA1 != objB0, Is.True);
            Assert.That(objA1 != objNull, Is.True);
            Assert.That(objB0 != objNull, Is.True);
#pragma warning disable CS1718 // 同じ変数と比較されました
            Assert.That(objA0 != objA0, Is.False);
            Assert.That(objA1 != objA1, Is.False);
            Assert.That(objB0 != objB0, Is.False);
            Assert.That(objNull != objNull, Is.False);
#pragma warning restore CS1718 // 同じ変数と比較されました
#pragma warning restore CS8604 // Null 参照引数の可能性があります。
        }
    }
}
