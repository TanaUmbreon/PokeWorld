namespace PokeWorld.Core.Models;

/// <summary>
/// 種族ごとの強さ (種族値) のセットを格納します。
/// </summary>
public class SpeciesStrengthSet
{
    /// <summary>
    /// HP 種族値を取得します。
    /// </summary>
    public SpeciesStrength HitPoint { get; }

    /// <summary>
    /// こうげき種族値を取得します。
    /// </summary>
    public SpeciesStrength Attack { get; }

    /// <summary>
    /// ぼうぎょ種族値を取得します。
    /// </summary>
    public SpeciesStrength Defense { get; }

    /// <summary>
    /// とくこう種族値を取得します。
    /// </summary>
    public SpeciesStrength SpecialAttack { get; }

    /// <summary>
    /// とくぼう種族値を取得します。
    /// </summary>
    public SpeciesStrength SpecialDefense { get; }

    /// <summary>
    /// すばやさ種族値を取得します。
    /// </summary>
    public SpeciesStrength Speed { get; }

    /// <summary>
    /// 指定したそれぞれの種族値で <see cref="SpeciesStrengthSet"/> の新しいインスタンスを生成します。
    /// </summary>
    /// <param name="hitPoint">HP 種族値。</param>
    /// <param name="attack">こうげき種族値。</param>
    /// <param name="defence">ぼうぎょ種族値。</param>
    /// <param name="specialAttack">とくこう種族値。</param>
    /// <param name="specialDefense">とくぼう種族値。</param>
    /// <param name="speed">すばやさ種族値。</param>
    public SpeciesStrengthSet(int hitPoint, int attack, int defence, int specialAttack, int specialDefense, int speed)
    {
        HitPoint = new SpeciesStrength(hitPoint);
        Attack = new SpeciesStrength(attack);
        Defense = new SpeciesStrength(defence);
        SpecialAttack = new SpeciesStrength(specialAttack);
        SpecialDefense = new SpeciesStrength(specialDefense);
        Speed = new SpeciesStrength(speed);
    }
}
