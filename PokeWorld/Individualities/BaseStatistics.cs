namespace PokeWorld.Individualities
{
    /// <summary>
    /// 種族値を表します。
    /// </summary>
    public class BaseStatistics
    {
        /// <summary>
        /// HP 種族値を取得します。
        /// </summary>
        public BaseStatistic<HitPoints> HP { get; private set; }

        /// <summary>
        /// こうげき種族値を取得します。
        /// </summary>
        public BaseStatistic<Attack> Attack { get; private set; }

        /// <summary>
        /// ぼうぎょ種族値を取得します。
        /// </summary>
        public BaseStatistic<Defense> Defense { get; private set; }

        /// <summary>
        /// とくこう種族値を取得します。
        /// </summary>
        public BaseStatistic<SpecialAttack> SpAttack { get; private set; }

        /// <summary>
        /// とくぼう種族値を取得します。
        /// </summary>
        public BaseStatistic<SpecialDefense> SpDefense { get; private set; }

        /// <summary>
        /// すばやさ種族値を取得します。
        /// </summary>
        public BaseStatistic<Speed> Speed { get; private set; }

        /// <summary>
        /// <see cref="BaseStatistics"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="hp">HP 種族値。</param>
        /// <param name="attack">こうげき種族値。</param>
        /// <param name="defense">ぼうぎょ種族値。</param>
        /// <param name="spAttack">とくこう種族値。</param>
        /// <param name="spDefense">とくぼう種族値。</param>
        /// <param name="speed">すばやさ種族値。</param>
        public BaseStatistics(
            BaseStatistic<HitPoints> hp,
            BaseStatistic<Attack> attack,
            BaseStatistic<Defense> defense,
            BaseStatistic<SpecialAttack> spAttack,
            BaseStatistic<SpecialDefense> spDefense,
            BaseStatistic<Speed> speed)
        {
            HP = hp;
            Attack = attack;
            Defense = defense;
            SpAttack = spAttack;
            SpDefense = spDefense;
            Speed = speed;
        }
    }
}
