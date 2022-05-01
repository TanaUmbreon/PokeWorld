namespace PokeWorld.Battles
{
    /// <summary>
    /// バトルの進行を制御します。
    /// </summary>
    public class BattleProgressController
    {
        private readonly BattleField _field;
        private bool _shouldEndBattle;
        private int _turnCount;

        public BattlePhase CurrentPhase { get; private set; }

        /// <summary>
        /// <see cref="BattleProgressController"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="field"></param>
        public BattleProgressController(BattleField field)
        {
            _field = field ?? throw new ArgumentNullException(nameof(field));
            _shouldEndBattle = false;
            _turnCount = 0;
        }


        public void Run()
        {
            BeginBattle();
            while (!_shouldEndBattle)
            {
                BeginTurn();
                ChooseCommand();
                EnterPokemon();
                UseMove();
                EndTurn();
            }
            EndBattle();
        }

        private void BeginBattle()
        {
            EnterEnemyPokemon();
            EnterPlayerPokemon();
        }

        private void EnterEnemyPokemon()
        {
            _field.EnterEnemyBattlePokemon();
        }

        private void EnterPlayerPokemon()
        {

        }

        private void BeginTurn()
        {
            _turnCount++;
        }

        private void ChooseCommand()
        {

        }

        private void UseMove()
        {

        }

        private void EndTurn()
        {
            _shouldEndBattle = true;
        }

        private void EndBattle()
        {

        }
    }
}
