namespace PokeWorld.Models
{
    /// <summary>
    /// 種族値を格納するレコードです。
    /// </summary>
    public record BaseStatsSet(
        int HitPoints,
        int Attack,
        int Defense,
        int SpecialAttack,
        int SpecialDefense,
        int Speed
        )
    {
        /// <summary>
        /// HP 種族値を取得します。
        /// </summary>
        public int HitPoints { get; init; } = HitPoints;

        /// <summary>
        /// こうげき種族値を取得します。
        /// </summary>
        public int Attack { get; init; } = Attack;

        /// <summary>
        /// ぼうぎょ種族値を取得します。
        /// </summary>
        public int Defense { get; init; } = Defense;

        /// <summary>
        /// とくこう種族値を取得します。
        /// </summary>
        public int SpecialAttack { get; init; } = SpecialAttack;

        /// <summary>
        /// とくぼう種族値を取得します。
        /// </summary>
        public int SpecialDefense { get; init; } = SpecialDefense;

        /// <summary>
        /// すばやさ種族値を取得します。
        /// </summary>
        public int Speed { get; init; } = Speed;
    }
}
