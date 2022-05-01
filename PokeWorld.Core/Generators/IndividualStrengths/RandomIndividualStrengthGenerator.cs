using PokeWorld.Core.Helpers;
using PokeWorld.Core.Models;

namespace PokeWorld.Core.Generators.IndividualStrengths;

/// <summary>
/// それぞれの個体値をランダムに決定して個体値のセットを生成する機能を提供します。
/// </summary>
public class RandomIndividualStrengthGenerator : IIndividualStrengthSetGenerator
{
    /// <summary>使用する乱数ジェネレーター</summary>
    private readonly IRandomizer _randomizer;

    /// <summary>
    /// <see cref="RandomIndividualStrengthGenerator"/> の新しいインスタンスを生成します。
    /// </summary>
    /// <param name="randomizer">使用する乱数ジェネレーター。</param>
    public RandomIndividualStrengthGenerator(IRandomizer randomizer)
        => _randomizer = randomizer;

    public IndividualStrengthSet Generate()
    {
        int next() => _randomizer.NextInt(IndividualStrength.Range);

        return new(next(), next(), next(), next(), next(), next());
    }
}
