namespace PokeWorld.Core.Helpers;

/// <summary>
/// 値の有効範囲を表します。このオブジェクトは不変です。
/// </summary>
public record ValueRange
{
    /// <summary>
    /// 最小有効値を取得します。
    /// </summary>
    public int Min { get; init; }

    /// <summary>
    /// 最大有効値を取得します。
    /// </summary>
    public int Max { get; init; }

    /// <summary>
    /// <see cref="ValueRange"/> の新しいインスタンスを生成します。
    /// </summary>
    /// <param name="min">最小有効値。</param>
    /// <param name="max">最大有効値。</param>
    public ValueRange(int min, int max)
    {
        if (min > max) { throw new ArgumentException("最小有効値が最大有効値を上回っています。"); }

        Min = min;
        Max = max;
    }

    /// <summary>
    /// 指定した値を <see cref="Min">Min</see> 以上 <see cref="Max">Max</see> 以下の範囲に収まるように固定して返します。
    /// </summary>
    /// <param name="value">固定される値。</param>
    /// <returns>
    /// <list type="bullet">
    /// <item><see cref="Min">Min</see> ≤ <paramref name="value"/> ≤ <see cref="Max">Max</see> の場合は <paramref name="value"/>。</item>
    /// <item><paramref name="value"/> &lt; <see cref="Min">Min</see> の場合は <see cref="Min">Min</see>。</item>
    /// <item><see cref="Max">Max</see> &lt; <paramref name="value"/> の場合は <see cref="Max">Max</see>。</item>
    /// </list>
    /// </returns>
    public int Clamp(int value)
        => Math.Clamp(value, Min, Max);

    /// <summary>
    /// 指定した値が <see cref="Min">Min</see> である事を判定します。
    /// </summary>
    /// <param name="value">判定する対象の値。</param>
    /// <returns><paramref name="value"/> = <see cref="Min">Min</see> の場合は true。それ以外の場合は false。</returns>
    public bool IsMin(int value)
        => value == Min;

    /// <summary>
    /// 指定した値が <see cref="Min">Min</see> 以下である事を判定します。
    /// </summary>
    /// <param name="value">判定する対象の値。</param>
    /// <returns><paramref name="value"/> ≤ <see cref="Min">Min</see> の場合は true。それ以外の場合は false。</returns>
    public bool IsMinOrLess(int value)
        => value <= Min;

    /// <summary>
    /// 指定した値が <see cref="Max">Max</see> である事を判定します。
    /// </summary>
    /// <param name="value">判定する対象の値。</param>
    /// <returns><see cref="Max">Max</see> = <paramref name="value"/> の場合は true。それ以外の場合は false。</returns>
    public bool IsMax(int value)
        => value == Max;

    /// <summary>
    /// 指定した値が <see cref="Max">Max</see> 以上である事を判定します。
    /// </summary>
    /// <param name="value">判定する対象の値。</param>
    /// <returns><see cref="Max">Max</see> ≤ <paramref name="value"/> の場合は true。それ以外の場合は false。</returns>
    public bool IsMaxOrGreater(int value)
        => value >= Max;
}
