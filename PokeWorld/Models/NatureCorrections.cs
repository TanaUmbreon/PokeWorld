namespace PokeWorld.Models
{
    /// <summary>
    /// せいかく補正のセットを表します。
    /// </summary>
    public class NatureCorrections
    {
        /// <summary>
        /// こうげきのせいかく補正を取得します。
        /// </summary>
        public NatureCorrection Attack { get; init; }

        /// <summary>
        /// ぼうぎょのせいかく補正を取得します。
        /// </summary>
        public NatureCorrection Defense { get; init; }

        /// <summary>
        /// とくこうのせいかく補正を取得します。
        /// </summary>
        public NatureCorrection SpAttack { get; init; }

        /// <summary>
        /// とくぼうのせいかく補正を取得します。
        /// </summary>
        public NatureCorrection SpDefense { get; init; }

        /// <summary>
        /// すばやさのせいかく補正を取得します。
        /// </summary>
        public NatureCorrection Speed { get; init; }

        /// <summary>
        /// <see cref="NatureCorrections"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="attack">こうげきのせいかく補正。</param>
        /// <param name="defense">ぼうぎょのせいかく補正。</param>
        /// <param name="spAttack">とくこうのせいかく補正。</param>
        /// <param name="spDefense">とくぼうのせいかく補正。</param>
        /// <param name="speed">すばやさのせいかく補正。</param>
        public NatureCorrections(
            NatureCorrection attack,
            NatureCorrection defense,
            NatureCorrection spAttack,
            NatureCorrection spDefense,
            NatureCorrection speed)
        {
            Attack = attack;
            Defense = defense;
            SpAttack = spAttack;
            SpDefense = spDefense;
            Speed = speed;
        }
    }
}
