using PokeWorld.Core.Helpers;

namespace PokeWorld.Core.Models;

/// <summary>
/// 基礎ポイント (努力値) を表します。このオブジェクトは不変です。
/// </summary>
/// <param name="Value">基礎ポイント。有効範囲外の値を指定した場合は範囲に収まるようにクランプします。</param>
public record BasePoint(int Value)
{
    /// <summary>基礎ポイントの有効範囲</summary>
    public static readonly ValueRange Range = new(min: 0, max: 252);
    /// <summary>値がゼロの基礎ポイント</summary>
    public static readonly BasePoint Zero = new(Range.Min);

    /// <summary>
    /// 基礎ポイントの実数値を取得します。
    /// </summary>
    public int Value { get; init; } = Range.Clamp(Value);

    /// <summary>
    /// 基礎ポイントが最大に達している事を判定します。
    /// </summary>
    /// <returns>基礎ポイントが最大に達している場合は true、そうでない場合は false。</returns>
    public bool IsMax()
         => Value >= Range.Max;

    /// <summary>
    /// 現在の基礎ポイントに指定した値を加算した新しい基礎ポイントを返します。
    /// </summary>
    /// <param name="value">加算する基礎ポイント。</param>
    /// <returns>現在の基礎ポイントに <paramref name="value"/> が加算され、かつ有効範囲内にクランプされた新しいインスタンスの基礎ポイント。</returns>
    public BasePoint Add(int value)
    {
        try
        {
            return new BasePoint(checked(Value + value));
        }
        catch (OverflowException)
        {
            // オーバーフローが発生しても有効範囲内でクランプされているように調整する
            return new BasePoint(value > 0 ? Range.Max : Range.Min);
        }
    }
}
