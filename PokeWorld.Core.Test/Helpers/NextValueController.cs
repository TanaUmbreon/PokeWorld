namespace PokeWorld.Core.Test.Helpers;

/// <summary>
/// <see cref="TestableRandomizer"/> で使用する、乱数生成時の戻り値を指定する為の機能を提供します。
/// </summary>
public class NextValueController
{
    /// <summary>
    /// 乱数生成で返す整数を取得または設定します。
    /// </summary>
    public int NextInt32Value { get; set; }

    /// <summary>
    /// <see cref="NextValueController"/> の新しいインスタンスを生成します。
    /// </summary>
    public NextValueController() { }
}
