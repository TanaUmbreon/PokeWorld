using PokeWorld.Core.Models;

namespace PokeWorld.Battles;

public class BattleField
{
    private readonly BattleFieldSide _playerSide;
    private readonly BattleFieldSide _enemySide;

    /// <summary>
    /// <see cref="BattleField"/> の新しいインスタンスを生成します。
    /// </summary>
    /// <param name="playerSide"></param>
    /// <param name="enemySide"></param>
    public BattleField(BattleFieldSide playerSide, BattleFieldSide enemySide)
    {
        _playerSide = playerSide ?? throw new ArgumentNullException(nameof(playerSide));
        _enemySide = enemySide ?? throw new ArgumentNullException(nameof(enemySide));
    }


    public void EnterEnemyBattlePokemon()
    {
    }
}
