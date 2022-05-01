namespace PokeWorld.Core.Models;

/// <summary>
/// 種族ごとの強さ (種族値) を格納します。
/// </summary>
public class SpeciesStrength
{
    /// <summary>種族値の最小値</summary>
    private const int MinValue = 1;
    /// <summary>種族値の最大値</summary>
    private const int MaxValue = 255;

    /// <summary>
    /// 種族値を取得します。
    /// </summary>
    public int Value { get; }

    /// <summary>
    /// <see cref="SpeciesStrength"/> の新しいインスタンスを生成します。
    /// </summary>
    /// <param name="value">種族値。範囲外の値を指定した場合は範囲に収まるよう調整します。</param>
    public SpeciesStrength(int value)
    {
        Value = Math.Clamp(value, MinValue, MaxValue);
    }
}
