namespace PokeWorld.Core.Helpers;

/// <summary>
/// 疑似乱数ジェネレーターです。
/// </summary>
public class Randomizer : IRandomizer
{
    private readonly Random _random = new();

    /// <summary>
    /// <see cref="Randomizer"/> の新しいインスタンスを生成します。
    /// </summary>
    public Randomizer() { }

    public int NextInt(int minValue, int maxValue)
        => _random.Next(minValue, maxValue);

    public int NextInt(int maxValue)
        => _random.Next(maxValue);

    public int NextInt(ValueRange range)
        => _random.Next(range.Min, range.Max + 1);

    public bool NextBool()
        => _random.Next(2) == 0;

    public T SelectOne<T>(IList<T> source)
    {
        if (source == null) { throw new ArgumentNullException(nameof(source)); }
        if (source.Count <= 0) { throw new ArgumentException($"要素が空のコレクションは指定できません。", nameof(source)); }

        return source[NextInt(0, source.Count)];
    }
}
