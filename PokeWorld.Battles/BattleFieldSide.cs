using PokeWorld.Core.Models;

namespace PokeWorld.Battles;

/// <summary>
/// 戦闘フィールドにおける、単一のプレイヤー側または敵側いずれかを表します。
/// </summary>
public class BattleFieldSide
{
    /// <summary>所持しているポケモンの一覧</summary>
    private readonly BattlePokemonHolder _pokemonList;

    /// <summary>戦闘中のポケモンの一覧</summary>
    private IEnumerable<Pokemon> _fightingPokemonList;

    /// <summary>場にまとめて繰り出せるポケモンの上限数</summary>
    private readonly int _fightingPokemonLimit;

    /// <summary>
    /// <see cref="BattleFieldSide"/> の新しいインスタンスを生成します。
    /// </summary>
    /// <param name="pokemonList">所持しているポケモンの一覧。</param>
    public BattleFieldSide(BattlePokemonHolder pokemonList, int fightingPokemonLimit)
    {
        _pokemonList = pokemonList ?? throw new ArgumentNullException(nameof(pokemonList));
        if (fightingPokemonLimit < 1) { throw new ArgumentOutOfRangeException(nameof(fightingPokemonLimit)); }

        _fightingPokemonList = Array.Empty<Pokemon>();
        _fightingPokemonLimit = fightingPokemonLimit;
    }
}
