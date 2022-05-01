#nullable disable

using PokeWorld.Core.Models;

namespace PokeWorld.Core.Test.Models;

[TestFixture]
public class BasePointSetTest
{
    [TestCase(0, 0)]
    [TestCase(197, 197)]
    [TestCase(252, 252)]
    [TestCase(253, 252)]
    [TestCase(int.MaxValue, 252)]
    [TestCase(-1, 0)]
    [TestCase(int.MinValue, 0)]
    public void TestHitPoint(int inputValue, int expectedValue)
    {
        var bpSet = new BasePointSet(inputValue, 0, 0, 0, 0, 0);
        Assert.That(bpSet.HitPoint.Value, Is.EqualTo(expectedValue));
    }

    [TestCase(0, 0)]
    [TestCase(197, 197)]
    [TestCase(252, 252)]
    [TestCase(253, 252)]
    [TestCase(int.MaxValue, 252)]
    [TestCase(-1, 0)]
    [TestCase(int.MinValue, 0)]
    public void TestAttack(int inputValue, int expectedValue)
    {
        var bpSet = new BasePointSet(0, inputValue, 0, 0, 0, 0);
        Assert.That(bpSet.Attack.Value, Is.EqualTo(expectedValue));
    }

    [TestCase(0, 0)]
    [TestCase(197, 197)]
    [TestCase(252, 252)]
    [TestCase(253, 252)]
    [TestCase(int.MaxValue, 252)]
    [TestCase(-1, 0)]
    [TestCase(int.MinValue, 0)]
    public void TestDefense(int inputValue, int expectedValue)
    {
        var bpSet = new BasePointSet(0, 0, inputValue, 0, 0, 0);
        Assert.That(bpSet.Defense.Value, Is.EqualTo(expectedValue));
    }

    [TestCase(0, 0)]
    [TestCase(197, 197)]
    [TestCase(252, 252)]
    [TestCase(253, 252)]
    [TestCase(int.MaxValue, 252)]
    [TestCase(-1, 0)]
    [TestCase(int.MinValue, 0)]
    public void TestSpecialAttack(int inputValue, int expectedValue)
    {
        var bpSet = new BasePointSet(0, 0, 0, inputValue, 0, 0);
        Assert.That(bpSet.SpecialAttack.Value, Is.EqualTo(expectedValue));
    }

    [TestCase(0, 0)]
    [TestCase(197, 197)]
    [TestCase(252, 252)]
    [TestCase(253, 252)]
    [TestCase(int.MaxValue, 252)]
    [TestCase(-1, 0)]
    [TestCase(int.MinValue, 0)]
    public void TestSpecialDefense(int inputValue, int expectedValue)
    {
        var bpSet = new BasePointSet(0, 0, 0, 0, inputValue, 0);
        Assert.That(bpSet.SpecialDefense.Value, Is.EqualTo(expectedValue));
    }

    [TestCase(0, 0)]
    [TestCase(197, 197)]
    [TestCase(252, 252)]
    [TestCase(253, 252)]
    [TestCase(int.MaxValue, 252)]
    [TestCase(-1, 0)]
    [TestCase(int.MinValue, 0)]
    public void TestSpeed(int inputValue, int expectedValue)
    {
        var bpSet = new BasePointSet(0, 0, 0, 0, 0, inputValue);
        Assert.That(bpSet.Speed.Value, Is.EqualTo(expectedValue));
    }

    [TestCase(85, 85, 85, 85, 85, 85)]
    [TestCase(0, 0, 0, 0, 0, 0)]
    [TestCase(-1, -1, -1, -1, -1, -1)]
    [TestCase(int.MinValue, int.MinValue, int.MinValue, int.MinValue, int.MinValue, int.MinValue)]
    [TestCase(510, 0, 0, 0, 0, 0)]
    [TestCase(511, 0, 0, 0, 0, 0)]
    [TestCase(int.MaxValue, 0, 0, 0, 0, 0)]
    [TestCase(0, 510, 0, 0, 0, 0)]
    [TestCase(0, 511, 0, 0, 0, 0)]
    [TestCase(0, int.MaxValue, 0, 0, 0, 0)]
    [TestCase(0, 0, 510, 0, 0, 0)]
    [TestCase(0, 0, 511, 0, 0, 0)]
    [TestCase(0, 0, int.MaxValue, 0, 0, 0)]
    [TestCase(0, 0, 0, 510, 0, 0)]
    [TestCase(0, 0, 0, 511, 0, 0)]
    [TestCase(0, 0, 0, int.MaxValue, 0, 0)]
    [TestCase(0, 0, 0, 0, 510, 0)]
    [TestCase(0, 0, 0, 0, 511, 0)]
    [TestCase(0, 0, 0, 0, int.MaxValue, 0)]
    [TestCase(0, 0, 0, 0, 0, 510)]
    [TestCase(0, 0, 0, 0, 0, 511)]
    [TestCase(0, 0, 0, 0, 0, int.MaxValue)]
    [TestCase(-1, 253, 253, 6, 0, 0)]
    public void TestNew1_ThrowsNothing(int hitPoint, int attack, int defence, int specialAttack, int specialDefense, int speed)
    {
        Assert.That(() => new BasePointSet(hitPoint, attack, defence, specialAttack, specialDefense, speed), Throws.Nothing);
    }

    [TestCase(86, 85, 85, 85, 85, 85)]
    [TestCase(85, 86, 85, 85, 85, 85)]
    [TestCase(85, 85, 86, 85, 85, 85)]
    [TestCase(85, 85, 85, 86, 85, 85)]
    [TestCase(85, 85, 85, 85, 86, 85)]
    [TestCase(85, 85, 85, 85, 85, 86)]
    [TestCase(-1, 253, 253, 7, 0, 0)]
    [TestCase(int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue)]
    public void TestNew1_ThrowsArgumentException(int hitPoint, int attack, int defence, int specialAttack, int specialDefense, int speed)
    {
        Assert.That(() => new BasePointSet(hitPoint, attack, defence, specialAttack, specialDefense, speed), Throws.ArgumentException);
    }

    [Test]
    public void TestNew2()
    {
        var bpSet = new BasePointSet();
        Assert.That(bpSet.HitPoint.Value, Is.EqualTo(0));
        Assert.That(bpSet.Attack.Value, Is.EqualTo(0));
        Assert.That(bpSet.Defense.Value, Is.EqualTo(0));
        Assert.That(bpSet.SpecialAttack.Value, Is.EqualTo(0));
        Assert.That(bpSet.SpecialDefense.Value, Is.EqualTo(0));
        Assert.That(bpSet.Speed.Value, Is.EqualTo(0));
    }

    [Description("加算前の基礎ポイントが全て80 (合計基礎ポイント: 480, 割り当て残り: 30)")]
    [TestCase(StatDetail.HitPoint, 0, 80, 80, 80, 80, 80, 80)]
    [TestCase(StatDetail.HitPoint, 1, 81, 80, 80, 80, 80, 80)]
    [TestCase(StatDetail.HitPoint, 30, 110, 80, 80, 80, 80, 80)]
    [TestCase(StatDetail.HitPoint, 31, 110, 80, 80, 80, 80, 80, Description = "合計基礎ポイントの上限を超えて加算されない")]
    [TestCase(StatDetail.HitPoint, int.MaxValue, 110, 80, 80, 80, 80, 80)]
    [TestCase(StatDetail.HitPoint, -1, 79, 80, 80, 80, 80, 80)]
    [TestCase(StatDetail.HitPoint, -80, 0, 80, 80, 80, 80, 80)]
    [TestCase(StatDetail.HitPoint, -81, 0, 80, 80, 80, 80, 80, Description = "基礎ポイントの下限を超えて減算されない")]
    [TestCase(StatDetail.HitPoint, int.MinValue, 0, 80, 80, 80, 80, 80)]
    [TestCase(StatDetail.Attack, 0, 80, 80, 80, 80, 80, 80)]
    [TestCase(StatDetail.Attack, 1, 80, 81, 80, 80, 80, 80)]
    [TestCase(StatDetail.Attack, 30, 80, 110, 80, 80, 80, 80)]
    [TestCase(StatDetail.Attack, 31, 80, 110, 80, 80, 80, 80)]
    [TestCase(StatDetail.Attack, int.MaxValue, 80, 110, 80, 80, 80, 80)]
    [TestCase(StatDetail.Attack, -1, 80, 79, 80, 80, 80, 80)]
    [TestCase(StatDetail.Attack, -80, 80, 0, 80, 80, 80, 80)]
    [TestCase(StatDetail.Attack, -81, 80, 0, 80, 80, 80, 80)]
    [TestCase(StatDetail.Attack, int.MinValue, 80, 0, 80, 80, 80, 80)]
    [TestCase(StatDetail.Defense, 0, 80, 80, 80, 80, 80, 80)]
    [TestCase(StatDetail.Defense, 1, 80, 80, 81, 80, 80, 80)]
    [TestCase(StatDetail.Defense, 30, 80, 80, 110, 80, 80, 80)]
    [TestCase(StatDetail.Defense, 31, 80, 80, 110, 80, 80, 80)]
    [TestCase(StatDetail.Defense, int.MaxValue, 80, 80, 110, 80, 80, 80)]
    [TestCase(StatDetail.Defense, -1, 80, 80, 79, 80, 80, 80)]
    [TestCase(StatDetail.Defense, -80, 80, 80, 0, 80, 80, 80)]
    [TestCase(StatDetail.Defense, -81, 80, 80, 0, 80, 80, 80)]
    [TestCase(StatDetail.Defense, int.MinValue, 80, 80, 0, 80, 80, 80)]
    [TestCase(StatDetail.SpecialAttack, 0, 80, 80, 80, 80, 80, 80)]
    [TestCase(StatDetail.SpecialAttack, 1, 80, 80, 80, 81, 80, 80)]
    [TestCase(StatDetail.SpecialAttack, 30, 80, 80, 80, 110, 80, 80)]
    [TestCase(StatDetail.SpecialAttack, 31, 80, 80, 80, 110, 80, 80)]
    [TestCase(StatDetail.SpecialAttack, int.MaxValue, 80, 80, 80, 110, 80, 80)]
    [TestCase(StatDetail.SpecialAttack, -1, 80, 80, 80, 79, 80, 80)]
    [TestCase(StatDetail.SpecialAttack, -80, 80, 80, 80, 0, 80, 80)]
    [TestCase(StatDetail.SpecialAttack, -81, 80, 80, 80, 0, 80, 80)]
    [TestCase(StatDetail.SpecialAttack, int.MinValue, 80, 80, 80, 0, 80, 80)]
    [TestCase(StatDetail.SpecialDefense, 0, 80, 80, 80, 80, 80, 80)]
    [TestCase(StatDetail.SpecialDefense, 1, 80, 80, 80, 80, 81, 80)]
    [TestCase(StatDetail.SpecialDefense, 30, 80, 80, 80, 80, 110, 80)]
    [TestCase(StatDetail.SpecialDefense, 31, 80, 80, 80, 80, 110, 80)]
    [TestCase(StatDetail.SpecialDefense, int.MaxValue, 80, 80, 80, 80, 110, 80)]
    [TestCase(StatDetail.SpecialDefense, -1, 80, 80, 80, 80, 79, 80)]
    [TestCase(StatDetail.SpecialDefense, -80, 80, 80, 80, 80, 0, 80)]
    [TestCase(StatDetail.SpecialDefense, -81, 80, 80, 80, 80, 0, 80)]
    [TestCase(StatDetail.SpecialDefense, int.MinValue, 80, 80, 80, 80, 0, 80)]
    [TestCase(StatDetail.Speed, 0, 80, 80, 80, 80, 80, 80)]
    [TestCase(StatDetail.Speed, 1, 80, 80, 80, 80, 80, 81)]
    [TestCase(StatDetail.Speed, 30, 80, 80, 80, 80, 80, 110)]
    [TestCase(StatDetail.Speed, 31, 80, 80, 80, 80, 80, 110)]
    [TestCase(StatDetail.Speed, int.MaxValue, 80, 80, 80, 80, 80, 110)]
    [TestCase(StatDetail.Speed, -1, 80, 80, 80, 80, 80, 79)]
    [TestCase(StatDetail.Speed, -80, 80, 80, 80, 80, 80, 0)]
    [TestCase(StatDetail.Speed, -81, 80, 80, 80, 80, 80, 0)]
    [TestCase(StatDetail.Speed, int.MinValue, 80, 80, 80, 80, 80, 0)]
    public void TestAdd_FromAll80(
        StatDetail expTarget,
        int expValue,
        int expectedHitPoint,
        int expectedAttack,
        int expectedDefense,
        int expectedSpecialAttack,
        int expectedSpecialDefense,
        int expectedSpeed)
    {
        var bpSet = new BasePointSet(80, 80, 80, 80, 80, 80);
        bpSet.Add(new BasePointExperience(expTarget, expValue));
        Assert.That(bpSet.HitPoint.Value, Is.EqualTo(expectedHitPoint));
        Assert.That(bpSet.Attack.Value, Is.EqualTo(expectedAttack));
        Assert.That(bpSet.Defense.Value, Is.EqualTo(expectedDefense));
        Assert.That(bpSet.SpecialAttack.Value, Is.EqualTo(expectedSpecialAttack));
        Assert.That(bpSet.SpecialDefense.Value, Is.EqualTo(expectedSpecialDefense));
        Assert.That(bpSet.Speed.Value, Is.EqualTo(expectedSpeed));
    }

    [Description("加算前の基礎ポイントが全て0 (合計基礎ポイント: 0, 割り当て残り: 510)")]
    [TestCase(StatDetail.HitPoint, 252, 252, 0, 0, 0, 0, 0)]
    [TestCase(StatDetail.HitPoint, 253, 252, 0, 0, 0, 0, 0, Description = "基礎ポイントの上限を超えて加算されない")]
    [TestCase(StatDetail.Attack, 252, 0, 252, 0, 0, 0, 0)]
    [TestCase(StatDetail.Attack, 253, 0, 252, 0, 0, 0, 0)]
    [TestCase(StatDetail.Defense, 252, 0, 0, 252, 0, 0, 0)]
    [TestCase(StatDetail.Defense, 253, 0, 0, 252, 0, 0, 0)]
    [TestCase(StatDetail.SpecialAttack, 252, 0, 0, 0, 252, 0, 0)]
    [TestCase(StatDetail.SpecialAttack, 253, 0, 0, 0, 252, 0, 0)]
    [TestCase(StatDetail.SpecialDefense, 252, 0, 0, 0, 0, 252, 0)]
    [TestCase(StatDetail.SpecialDefense, 253, 0, 0, 0, 0, 252, 0)]
    [TestCase(StatDetail.Speed, 252, 0, 0, 0, 0, 0, 252)]
    [TestCase(StatDetail.Speed, 253, 0, 0, 0, 0, 0, 252)]
    public void TestAdd_FromAll0(
        StatDetail expTarget,
        int expValue,
        int expectedHitPoint,
        int expectedAttack,
        int expectedDefense,
        int expectedSpecialAttack,
        int expectedSpecialDefense,
        int expectedSpeed)
    {
        var bpSet = new BasePointSet(0, 0, 0, 0, 0, 0);
        bpSet.Add(new BasePointExperience(expTarget, expValue));
        Assert.That(bpSet.HitPoint.Value, Is.EqualTo(expectedHitPoint));
        Assert.That(bpSet.Attack.Value, Is.EqualTo(expectedAttack));
        Assert.That(bpSet.Defense.Value, Is.EqualTo(expectedDefense));
        Assert.That(bpSet.SpecialAttack.Value, Is.EqualTo(expectedSpecialAttack));
        Assert.That(bpSet.SpecialDefense.Value, Is.EqualTo(expectedSpecialDefense));
        Assert.That(bpSet.Speed.Value, Is.EqualTo(expectedSpeed));
    }

    [Description("加算前の基礎ポイントが全て85で合計基礎ポイントの上限に達している状態")]
    [TestCase(StatDetail.HitPoint, 0, 85, 85, 85, 85, 85, 85)]
    [TestCase(StatDetail.HitPoint, 1, 85, 85, 85, 85, 85, 85, Description = "合計基礎ポイントの上限だと加算されない")]
    [TestCase(StatDetail.HitPoint, int.MaxValue, 85, 85, 85, 85, 85, 85)]
    [TestCase(StatDetail.HitPoint, -1, 84, 85, 85, 85, 85, 85, Description = "合計基礎ポイントの上限でも減算される")]
    [TestCase(StatDetail.HitPoint, -85, 0, 85, 85, 85, 85, 85)]
    [TestCase(StatDetail.HitPoint, int.MinValue, 0, 85, 85, 85, 85, 85)]
    [TestCase(StatDetail.Attack, 0, 85, 85, 85, 85, 85, 85)]
    [TestCase(StatDetail.Attack, 1, 85, 85, 85, 85, 85, 85)]
    [TestCase(StatDetail.Attack, int.MaxValue, 85, 85, 85, 85, 85, 85)]
    [TestCase(StatDetail.Attack, -1, 85, 84, 85, 85, 85, 85)]
    [TestCase(StatDetail.Attack, -85, 85, 0, 85, 85, 85, 85)]
    [TestCase(StatDetail.Attack, int.MinValue, 85, 0, 85, 85, 85, 85)]
    [TestCase(StatDetail.Defense, 0, 85, 85, 85, 85, 85, 85)]
    [TestCase(StatDetail.Defense, 1, 85, 85, 85, 85, 85, 85)]
    [TestCase(StatDetail.Defense, int.MaxValue, 85, 85, 85, 85, 85, 85)]
    [TestCase(StatDetail.Defense, -1, 85, 85, 84, 85, 85, 85)]
    [TestCase(StatDetail.Defense, -85, 85, 85, 0, 85, 85, 85)]
    [TestCase(StatDetail.Defense, int.MinValue, 85, 85, 0, 85, 85, 85)]
    [TestCase(StatDetail.SpecialAttack, 0, 85, 85, 85, 85, 85, 85)]
    [TestCase(StatDetail.SpecialAttack, 1, 85, 85, 85, 85, 85, 85)]
    [TestCase(StatDetail.SpecialAttack, int.MaxValue, 85, 85, 85, 85, 85, 85)]
    [TestCase(StatDetail.SpecialAttack, -1, 85, 85, 85, 84, 85, 85)]
    [TestCase(StatDetail.SpecialAttack, -85, 85, 85, 85, 0, 85, 85)]
    [TestCase(StatDetail.SpecialAttack, int.MinValue, 85, 85, 85, 0, 85, 85)]
    [TestCase(StatDetail.SpecialDefense, 0, 85, 85, 85, 85, 85, 85)]
    [TestCase(StatDetail.SpecialDefense, 1, 85, 85, 85, 85, 85, 85)]
    [TestCase(StatDetail.SpecialDefense, int.MaxValue, 85, 85, 85, 85, 85, 85)]
    [TestCase(StatDetail.SpecialDefense, -1, 85, 85, 85, 85, 84, 85)]
    [TestCase(StatDetail.SpecialDefense, -85, 85, 85, 85, 85, 0, 85)]
    [TestCase(StatDetail.SpecialDefense, int.MinValue, 85, 85, 85, 85, 0, 85)]
    [TestCase(StatDetail.Speed, 0, 85, 85, 85, 85, 85, 85)]
    [TestCase(StatDetail.Speed, 1, 85, 85, 85, 85, 85, 85)]
    [TestCase(StatDetail.Speed, int.MaxValue, 85, 85, 85, 85, 85, 85)]
    [TestCase(StatDetail.Speed, -1, 85, 85, 85, 85, 85, 84)]
    [TestCase(StatDetail.Speed, -85, 85, 85, 85, 85, 85, 0)]
    [TestCase(StatDetail.Speed, int.MinValue, 85, 85, 85, 85, 85, 0)]
    public void TestAdd_FromAll85(
        StatDetail expTarget,
        int expValue,
        int expectedHitPoint,
        int expectedAttack,
        int expectedDefense,
        int expectedSpecialAttack,
        int expectedSpecialDefense,
        int expectedSpeed)
    {
        var bpSet = new BasePointSet(85, 85, 85, 85, 85, 85);
        bpSet.Add(new BasePointExperience(expTarget, expValue));
        Assert.That(bpSet.HitPoint.Value, Is.EqualTo(expectedHitPoint));
        Assert.That(bpSet.Attack.Value, Is.EqualTo(expectedAttack));
        Assert.That(bpSet.Defense.Value, Is.EqualTo(expectedDefense));
        Assert.That(bpSet.SpecialAttack.Value, Is.EqualTo(expectedSpecialAttack));
        Assert.That(bpSet.SpecialDefense.Value, Is.EqualTo(expectedSpecialDefense));
        Assert.That(bpSet.Speed.Value, Is.EqualTo(expectedSpeed));
    }

    [Test]
    public void TestAdd_ThrowsArgumentNullException()
    {
        var bpSet = new BasePointSet();
        Assert.That(() => bpSet.Add(null), Throws.ArgumentNullException);
    }

    [Test]
    public void TestAdd_InvalidExp()
    {
        // こういうごり押しキャストで生成した範囲外のステータスに対して加算する
        var exp = new BasePointExperience((StatDetail)6, 1);
        var bpSet = new BasePointSet();
        bpSet.Add(exp);

        // どの基礎ポイントも変化せず、例外も起きない
        Assert.That(bpSet.HitPoint.Value, Is.EqualTo(0));
        Assert.That(bpSet.Attack.Value, Is.EqualTo(0));
        Assert.That(bpSet.Defense.Value, Is.EqualTo(0));
        Assert.That(bpSet.SpecialAttack.Value, Is.EqualTo(0));
        Assert.That(bpSet.SpecialDefense.Value, Is.EqualTo(0));
        Assert.That(bpSet.Speed.Value, Is.EqualTo(0));
    }

    [Test(Description = "ステートフルであることの検証")]
    public void TestStateful()
    {
        // 合計基礎ポイントが252
        var bpSet = new BasePointSet(4, 8, 16, 32, 64, 128);
        Assert.That(bpSet.HitPoint.Value, Is.EqualTo(4));
        Assert.That(bpSet.Attack.Value, Is.EqualTo(8));
        Assert.That(bpSet.Defense.Value, Is.EqualTo(16));
        Assert.That(bpSet.SpecialAttack.Value, Is.EqualTo(32));
        Assert.That(bpSet.SpecialDefense.Value, Is.EqualTo(64));
        Assert.That(bpSet.Speed.Value, Is.EqualTo(128));

        // 合計基礎ポイントが252→492
        bpSet.Add(new BasePointExperience(StatDetail.HitPoint, 240));
        Assert.That(bpSet.HitPoint.Value, Is.EqualTo(244));
        Assert.That(bpSet.Attack.Value, Is.EqualTo(8));
        Assert.That(bpSet.Defense.Value, Is.EqualTo(16));
        Assert.That(bpSet.SpecialAttack.Value, Is.EqualTo(32));
        Assert.That(bpSet.SpecialDefense.Value, Is.EqualTo(64));
        Assert.That(bpSet.Speed.Value, Is.EqualTo(128));

        // 合計基礎ポイントが492→500 (HP基礎ポイントの上限に達するので指定した数値まで増加しない)
        bpSet.Add(new BasePointExperience(StatDetail.HitPoint, 20));
        Assert.That(bpSet.HitPoint.Value, Is.EqualTo(252));
        Assert.That(bpSet.Attack.Value, Is.EqualTo(8));
        Assert.That(bpSet.Defense.Value, Is.EqualTo(16));
        Assert.That(bpSet.SpecialAttack.Value, Is.EqualTo(32));
        Assert.That(bpSet.SpecialDefense.Value, Is.EqualTo(64));
        Assert.That(bpSet.Speed.Value, Is.EqualTo(128));

        // 合計基礎ポイントが500→510 (合計基礎ポイントの上限に達するので指定した数値まで増加しない)
        bpSet.Add(new BasePointExperience(StatDetail.Attack, int.MaxValue));
        Assert.That(bpSet.HitPoint.Value, Is.EqualTo(252));
        Assert.That(bpSet.Attack.Value, Is.EqualTo(18));
        Assert.That(bpSet.Defense.Value, Is.EqualTo(16));
        Assert.That(bpSet.SpecialAttack.Value, Is.EqualTo(32));
        Assert.That(bpSet.SpecialDefense.Value, Is.EqualTo(64));
        Assert.That(bpSet.Speed.Value, Is.EqualTo(128));

        // 合計基礎ポイントが510のまま (合計基礎ポイントの上限に達しているので変化しない)
        bpSet.Add(new BasePointExperience(StatDetail.Attack, int.MaxValue));
        Assert.That(bpSet.HitPoint.Value, Is.EqualTo(252));
        Assert.That(bpSet.Attack.Value, Is.EqualTo(18));
        Assert.That(bpSet.Defense.Value, Is.EqualTo(16));
        Assert.That(bpSet.SpecialAttack.Value, Is.EqualTo(32));
        Assert.That(bpSet.SpecialDefense.Value, Is.EqualTo(64));
        Assert.That(bpSet.Speed.Value, Is.EqualTo(128));

        // 合計基礎ポイントが510→509 (合計基礎ポイントの上限に達しても値を減少させることはできる)
        bpSet.Add(new BasePointExperience(StatDetail.HitPoint, -1));
        Assert.That(bpSet.HitPoint.Value, Is.EqualTo(251));
        Assert.That(bpSet.Attack.Value, Is.EqualTo(18));
        Assert.That(bpSet.Defense.Value, Is.EqualTo(16));
        Assert.That(bpSet.SpecialAttack.Value, Is.EqualTo(32));
        Assert.That(bpSet.SpecialDefense.Value, Is.EqualTo(64));
        Assert.That(bpSet.Speed.Value, Is.EqualTo(128));

        // 合計基礎ポイントが509→510 (減少して合計基礎ポイント未満になれば再度増加させることができる)
        bpSet.Add(new BasePointExperience(StatDetail.Attack, 1));
        Assert.That(bpSet.HitPoint.Value, Is.EqualTo(251));
        Assert.That(bpSet.Attack.Value, Is.EqualTo(19));
        Assert.That(bpSet.Defense.Value, Is.EqualTo(16));
        Assert.That(bpSet.SpecialAttack.Value, Is.EqualTo(32));
        Assert.That(bpSet.SpecialDefense.Value, Is.EqualTo(64));
        Assert.That(bpSet.Speed.Value, Is.EqualTo(128));

        bpSet.Add(new BasePointExperience(StatDetail.SpecialAttack, -32));
        Assert.That(bpSet.HitPoint.Value, Is.EqualTo(251));
        Assert.That(bpSet.Attack.Value, Is.EqualTo(19));
        Assert.That(bpSet.Defense.Value, Is.EqualTo(16));
        Assert.That(bpSet.SpecialAttack.Value, Is.EqualTo(0));
        Assert.That(bpSet.SpecialDefense.Value, Is.EqualTo(64));
        Assert.That(bpSet.Speed.Value, Is.EqualTo(128));

        // 基礎ポイントを減少させても0未満にはできない
        bpSet.Add(new BasePointExperience(StatDetail.SpecialAttack, -1));
        Assert.That(bpSet.HitPoint.Value, Is.EqualTo(251));
        Assert.That(bpSet.Attack.Value, Is.EqualTo(19));
        Assert.That(bpSet.Defense.Value, Is.EqualTo(16));
        Assert.That(bpSet.SpecialAttack.Value, Is.EqualTo(0));
        Assert.That(bpSet.SpecialDefense.Value, Is.EqualTo(64));
        Assert.That(bpSet.Speed.Value, Is.EqualTo(128));

        bpSet.Add(new BasePointExperience(StatDetail.SpecialAttack, int.MinValue));
        Assert.That(bpSet.HitPoint.Value, Is.EqualTo(251));
        Assert.That(bpSet.Attack.Value, Is.EqualTo(19));
        Assert.That(bpSet.Defense.Value, Is.EqualTo(16));
        Assert.That(bpSet.SpecialAttack.Value, Is.EqualTo(0));
        Assert.That(bpSet.SpecialDefense.Value, Is.EqualTo(64));
        Assert.That(bpSet.Speed.Value, Is.EqualTo(128));
    }
}
