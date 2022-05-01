using PokeWorld.Core.Helpers;

namespace PokeWorld.Core.Models;

/// <summary>
/// 基礎ポイント (努力値) のセットを格納します。
/// </summary>
public class BasePointSet
{
    /// <summary>合計した基礎ポイントの有効範囲</summary>
    public static readonly ValueRange TotalValueRange = new(min: 0, max: 510);

    /// <summary>
    /// HP 基礎ポイントを取得します。
    /// </summary>
    public BasePoint HitPoint { get; private set; }

    /// <summary>
    /// こうげき基礎ポイントを取得します。
    /// </summary>
    public BasePoint Attack { get; private set; }

    /// <summary>
    /// ぼうぎょ基礎ポイントを取得します。
    /// </summary>
    public BasePoint Defense { get; private set; }

    /// <summary>
    /// とくこう基礎ポイントを取得します。
    /// </summary>
    public BasePoint SpecialAttack { get; private set; }

    /// <summary>
    /// とくぼう基礎ポイントを取得します。
    /// </summary>
    public BasePoint SpecialDefense { get; private set; }

    /// <summary>
    /// すばやさ基礎ポイントを取得します。
    /// </summary>
    public BasePoint Speed { get; private set; }

    /// <summary>
    /// 全ての基礎ポイントがゼロで <see cref="BasePointSet"/> の新しいインスタンスを生成します。
    /// </summary>
    public BasePointSet()
        : this(
              BasePoint.Zero,
              BasePoint.Zero,
              BasePoint.Zero,
              BasePoint.Zero,
              BasePoint.Zero,
              BasePoint.Zero)
    { }

    /// <summary>
    /// 指定したそれぞれの基礎ポイントで <see cref="BasePointSet"/> の新しいインスタンスを生成します。
    /// </summary>
    /// <param name="hitPoint">HP 基礎ポイント。</param>
    /// <param name="attack">こうげき基礎ポイント。</param>
    /// <param name="defense">ぼうぎょ基礎ポイント。</param>
    /// <param name="specialAttack">とくこう基礎ポイント。</param>
    /// <param name="specialDefense">とくぼう基礎ポイント。</param>
    /// <param name="speed">すばやさ基礎ポイント。</param>
    public BasePointSet(int hitPoint, int attack, int defense, int specialAttack, int specialDefense, int speed)
        : this(
              new BasePoint(hitPoint),
              new BasePoint(attack),
              new BasePoint(defense),
              new BasePoint(specialAttack),
              new BasePoint(specialDefense),
              new BasePoint(speed))
    { }

    /// <summary>
    /// 指定したそれぞれの基礎ポイントで <see cref="BasePointSet"/> の新しいインスタンスを生成します。
    /// </summary>
    /// <param name="hitPoint">HP 基礎ポイント。</param>
    /// <param name="attack">こうげき基礎ポイント。</param>
    /// <param name="defense">ぼうぎょ基礎ポイント。</param>
    /// <param name="specialAttack">とくこう基礎ポイント。</param>
    /// <param name="specialDefense">とくぼう基礎ポイント。</param>
    /// <param name="speed">すばやさ基礎ポイント。</param>
    private BasePointSet(BasePoint hitPoint, BasePoint attack, BasePoint defense, BasePoint specialAttack, BasePoint specialDefense, BasePoint speed)
    {
        HitPoint = hitPoint;
        Attack = attack;
        Defense = defense;
        SpecialAttack = specialAttack;
        SpecialDefense = specialDefense;
        Speed = speed;

        if (GetTotalValue() > TotalValueRange.Max)
        {
            throw new ArgumentException($"合計基礎ポイントが最大値 {TotalValueRange.Max} を上回ります。");
        }
    }

    /// <summary>
    /// 合計した基礎ポイントを返します。
    /// </summary>
    /// <returns>それぞれのステータスの基礎ポイントを合計した値。</returns>
    public int GetTotalValue()
        => HitPoint.Value + Attack.Value + Defense.Value + SpecialAttack.Value + SpecialDefense.Value + Speed.Value;

    /// <summary>
    /// 合計した基礎ポイントが最大に達している事を判定します。
    /// </summary>
    /// <returns>合計した基礎ポイントが最大に達している場合は true、そうでない場合は false。</returns>
    public bool IsMaxTotalValue()
        => GetTotalValue() >= TotalValueRange.Max;

    /// <summary>
    /// 指定した値で基礎ポイントを加算します。
    /// </summary>
    /// <param name="exp">加算する基礎ポイント。</param>
    public void Add(BasePointExperience exp)
    {
        if (exp == null) { throw new ArgumentNullException(nameof(exp)); }

        // 最大合計値に達している場合では値を増やせない(減らすことはできる)
        int remainingTotal = TotalValueRange.Max - GetTotalValue();
        if (remainingTotal <= 0 && exp.Value >= 0) { return; }

        int correctedValue = Math.Min(exp.Value, remainingTotal);
        switch (exp.Target)
        {
            case StatDetail.HitPoint:
                HitPoint = HitPoint.Add(correctedValue);
                break;
            case StatDetail.Attack:
                Attack = Attack.Add(correctedValue);
                break;
            case StatDetail.Defense:
                Defense = Defense.Add(correctedValue);
                break;
            case StatDetail.SpecialAttack:
                SpecialAttack = SpecialAttack.Add(correctedValue);
                break;
            case StatDetail.SpecialDefense:
                SpecialDefense = SpecialDefense.Add(correctedValue);
                break;
            case StatDetail.Speed:
                Speed = Speed.Add(correctedValue);
                break;
        }
    }
}
