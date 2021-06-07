namespace PokeWorld.Models
{
    /// <summary>
    /// 基礎ポイント (努力値) を格納するレコードです。
    /// </summary>
    public record BasePointsSet(
        int HitPoints = 0,
        int Attack = 0,
        int Defense = 0,
        int SpecialAttack = 0,
        int SpecialDefense = 0,
        int Speed = 0
        )
    {
        /// <summary>
        /// HP 基礎ポイントを取得します。
        /// </summary>
        public int HitPoints { get; init; } = HitPoints;

        /// <summary>
        /// こうげき基礎ポイントを取得します。
        /// </summary>
        public int Attack { get; init; } = Attack;

        /// <summary>
        /// ぼうぎょ基礎ポイントを取得します。
        /// </summary>
        public int Defense { get; init; } = Defense;

        /// <summary>
        /// とくこう基礎ポイントを取得します。
        /// </summary>
        public int SpecialAttack { get; init; } = SpecialAttack;

        /// <summary>
        /// とくぼう基礎ポイントを取得します。
        /// </summary>
        public int SpecialDefense { get; init; } = SpecialDefense;

        /// <summary>
        /// すばやさ基礎ポイントを取得します。
        /// </summary>
        public int Speed { get; init; } = Speed;
    }
}
