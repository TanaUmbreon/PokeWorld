namespace PokeWorld.Core.Models;

/// <summary>
/// 経験値として加算する基礎ポイント (努力値) を表します。このオブジェクトは不変です。
/// </summary>
/// <param name="Target">加算対象のステータス。</param>
/// <param name="Value">加算する基礎ポイント。</param>
public record BasePointExperience(StatDetail Target, int Value)
{
    /// <summary>
    /// 加算対象のステータスを取得します。
    /// </summary>
    public StatDetail Target { get; init; } = Target;

    /// <summary>
    /// 加算する基礎ポイントを取得します。
    /// </summary>
    public int Value { get; init; } = Value;
}
