using PokeWorld.Core.Models;

namespace PokeWorld.Core.Generators.IndividualStrengths;

/// <summary>
/// 固定された個体値のセットを生成する機能を提供します。
/// </summary>
public class FixedIndividualStrengthGenerator : IIndividualStrengthSetGenerator
{
    private readonly int _hitPoint;
    private readonly int _attack;
    private readonly int _defence;
    private readonly int _specialAttack;
    private readonly int _specialDefense;
    private readonly int _speed;

    /// <summary>
    /// 指定したそれぞれの個体値 (すごいとっくんで鍛えていない状態のもの) で
    /// <see cref="FixedIndividualStrengthGenerator"/> の新しいインスタンスを生成します。
    /// </summary>
    /// <param name="hitPoint">HP 個体値。</param>
    /// <param name="attack">こうげき個体値。</param>
    /// <param name="defence">ぼうぎょ個体値。</param>
    /// <param name="specialAttack">とくこう個体値。</param>
    /// <param name="specialDefense">とくぼう個体値。</param>
    /// <param name="speed">すばやさ個体値。</param>
    public FixedIndividualStrengthGenerator(int hitPoint, int attack, int defence, int specialAttack, int specialDefense, int speed)
    {
        _hitPoint = hitPoint;
        _attack = attack;
        _defence = defence;
        _specialAttack = specialAttack;
        _specialDefense = specialDefense;
        _speed = speed;
    }

    public IndividualStrengthSet Generate()
        => new IndividualStrengthSet(_hitPoint, _attack, _defence, _specialAttack, _specialDefense, _speed);
}
