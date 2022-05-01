using PokeWorld.Core.Models;

namespace PokeWorld.Core.Generators;

/// <summary>
/// 個体値のセットを生成するアルゴリズムを提供します。
/// </summary>
public interface IIndividualStrengthSetGenerator
{
    /// <summary>
    /// 個体値のセットを生成します。
    /// </summary>
    /// <returns>個体値のセット。</returns>
    IndividualStrengthSet Generate();
}
