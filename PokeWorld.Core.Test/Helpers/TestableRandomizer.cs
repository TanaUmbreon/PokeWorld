using PokeWorld.Core.Helpers;

namespace PokeWorld.Core.Test.Helpers;

/// <summary>
/// ユニット テスト用に使用する疑似乱数ジェネレーターを表します。
/// <see cref="NextValueController"/> を使用することで返す値を指定することができます。
/// </summary>
public class TestableRandomizer : IRandomizer
{
    private readonly NextValueController _controller;

    /// <summary>
    /// <see cref="TestableRandomizer"/> の新しいインスタンスを生成します。
    /// </summary>
    /// <param name="controller">乱数生成の戻り値を指定するための操作オブジェクト。</param>
    public TestableRandomizer(NextValueController controller)
        => _controller = controller ?? throw new ArgumentNullException(nameof(controller));

    public int NextInt(int minValue, int maxValue)
    {
        if (_controller.NextInt32Value < minValue || _controller.NextInt32Value >= maxValue)
        {
            throw new InvalidOperationException($"{minValue} 以上 {maxValue} 未満の乱数生成において、 {nameof(NextValueController)} は戻り値 {_controller.NextInt32Value} を返そうとしました。");
        }
        return _controller.NextInt32Value;
    }

    public int NextInt(int maxValue)
        => NextInt(0, maxValue);

    public bool NextBool()
        => NextInt(0, 2) == 1;

    public T SelectOne<T>(IList<T> source)
    {
        if (source == null) { throw new ArgumentNullException(nameof(source)); }
        if (source.Count <= 0) { throw new ArgumentException($"要素が空のコレクションは指定できません。", nameof(source)); }

        return source[NextInt(0, source.Count)];
    }

    public int NextInt(ValueRange range)
    {
        throw new NotImplementedException();
    }
}
