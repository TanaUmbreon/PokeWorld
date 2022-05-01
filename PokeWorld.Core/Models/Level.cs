using PokeWorld.Core.Helpers;

namespace PokeWorld.Core.Models;

/// <summary>
/// レベルを表します。このオブジェクトは不変です。
/// </summary>
/// <param name="value">レベルの値。有効範囲外の値を指定した場合は範囲に収まるようにクランプします。</param>
public record Level(int value)
{
    /// <summary>レベルの有効範囲</summary>
    private static readonly ValueRange _range = new(min: 1, max: 100);

    /// <summary>
    /// レベルの値を取得します。
    /// </summary>
    public int Value { get; init; } = _range.Clamp(value);

    /// <summary>
    /// レベルが最大に達している事を判定します。
    /// </summary>
    /// <returns>レベルが最大に達している場合は true、そうでない場合は false。</returns>
    public bool IsMax()
         => Value >= _range.Max;

    /// <summary>
    /// 現在のレベルに指定した値を加算した新しいレベルを返します。
    /// </summary>
    /// <param name="value">加算するレベル。</param>
    /// <returns>現在のレベルに <paramref name="value"/> が加算され、かつ有効範囲内にクランプされた新しいインスタンスのレベル。</returns>
    public Level Add(int value)
    {
        try
        {
            return new Level(checked(Value + value));
        }
        catch (OverflowException)
        {
            // オーバーフローが発生しても有効範囲内でクランプされているように調整する
            return new Level(value > 0 ? _range.Max : _range.Min);
        }
    }
}
