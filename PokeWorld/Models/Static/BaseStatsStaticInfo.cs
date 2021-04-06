namespace PokeWorld.Models.Static
{
    /// <summary>
    /// 種族値の静的データを格納します。
    /// </summary>
    public class BaseStatsStaticInfo
    {
        /// <summary>
        /// HP を取得します。
        /// </summary>
        public int HitPoints { get; init; }

        /// <summary>
        /// こうげきを取得します。
        /// </summary>
        public int Attack { get; init; }

        /// <summary>
        /// ぼうぎょを取得します。
        /// </summary>
        public int Defense { get; init; }

        /// <summary>
        /// とくこうを取得します。
        /// </summary>
        public int SpecialAttack { get; init; }

        /// <summary>
        /// とくぼうを取得します。
        /// </summary>
        public int SpecialDefense { get; init; }

        /// <summary>
        /// すばやさを取得します。
        /// </summary>
        public int Speed { get; init; }

        /// <summary>
        /// <see cref="BaseStatsStaticInfo"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="hitPoints">HP。</param>
        /// <param name="attack">こうげき。</param>
        /// <param name="defense">ぼうぎょ。</param>
        /// <param name="specialAttack">とくこう。</param>
        /// <param name="specialDefense">とくぼう。</param>
        /// <param name="speed">すばやさ。</param>
        public BaseStatsStaticInfo(int hitPoints, int attack, int defense, int specialAttack, int specialDefense, int speed)
        {
            HitPoints = hitPoints;
            Attack = attack;
            Defense = defense;
            SpecialAttack = specialAttack;
            SpecialDefense = specialDefense;
            Speed = speed;
        }
    }
}
