namespace PokeWorld.Core.Models;

/// <summary>
/// 生まれつきの強さ (個体値) のセットを格納します。
/// </summary>
public class IndividualStrengthSet
{
    /// <summary>
    /// HP の生まれつきの強さを取得します。
    /// </summary>
    public IndividualStrength HitPoint { get; private set; }

    /// <summary>
    /// こうげきの生まれつきの強さを取得します。
    /// </summary>
    public IndividualStrength Attack { get; private set; }

    /// <summary>
    /// ぼうぎょの生まれつきの強さを取得します。
    /// </summary>
    public IndividualStrength Defense { get; private set; }

    /// <summary>
    /// とくこうの生まれつきの強さを取得します。
    /// </summary>
    public IndividualStrength SpecialAttack { get; private set; }

    /// <summary>
    /// とくぼうの生まれつきの強さを取得します。
    /// </summary>
    public IndividualStrength SpecialDefense { get; private set; }

    /// <summary>
    /// すばやさの生まれつきの強さを取得します。
    /// </summary>
    public IndividualStrength Speed { get; private set; }

    /// <summary>
    /// 指定したそれぞれの生まれつきの強さで <see cref="IndividualStrengthSet"/> の新しいインスタンスを生成します。
    /// </summary>
    /// <param name="hitPoint">HP の生まれつきの強さ。</param>
    /// <param name="attack">こうげきの生まれつきの強さ。</param>
    /// <param name="defence">ぼうぎょの生まれつきの強さ。</param>
    /// <param name="specialAttack">とくこうの生まれつきの強さ。</param>
    /// <param name="specialDefense">とくぼうの生まれつきの強さ。</param>
    /// <param name="speed">すばやさの生まれつきの強さ。</param>
    public IndividualStrengthSet(
        IndividualStrength hitPoint,
        IndividualStrength attack,
        IndividualStrength defence,
        IndividualStrength specialAttack,
        IndividualStrength specialDefense,
        IndividualStrength speed)
    {
        HitPoint = hitPoint ?? throw new ArgumentNullException(nameof(hitPoint));
        Attack = attack ?? throw new ArgumentNullException(nameof(attack));
        Defense = defence ?? throw new ArgumentNullException(nameof(defence));
        SpecialAttack = specialAttack ?? throw new ArgumentNullException(nameof(specialAttack));
        SpecialDefense = specialDefense ?? throw new ArgumentNullException(nameof(specialDefense));
        Speed = speed ?? throw new ArgumentNullException(nameof(speed));
    }

    /// <summary>
    /// 指定したそれぞれの生まれつきの強さ (すごいとっくんで鍛えていない状態のもの) で
    /// <see cref="IndividualStrengthSet"/> の新しいインスタンスを生成します。
    /// </summary>
    /// <param name="hitPoint">HP の生まれつきの強さ。</param>
    /// <param name="attack">こうげきの生まれつきの強さ。</param>
    /// <param name="defence">ぼうぎょの生まれつきの強さ。</param>
    /// <param name="specialAttack">とくこうの生まれつきの強さ。</param>
    /// <param name="specialDefense">とくぼうの生まれつきの強さ。</param>
    /// <param name="speed">すばやさの生まれつきの強さ。</param>
    public IndividualStrengthSet(int hitPoint, int attack, int defence, int specialAttack, int specialDefense, int speed)
        : this(
            new IndividualStrength(hitPoint),
            new IndividualStrength(attack),
            new IndividualStrength(defence),
            new IndividualStrength(specialAttack),
            new IndividualStrength(specialDefense),
            new IndividualStrength(speed))
    { }
}
