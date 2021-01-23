namespace PokeWorld.Models.Static
{
    /// <summary>
    /// せいかくの静的データを格納します。
    /// </summary>
    public record NatureStaticInfo(
        string Key,
        int Id,
        NatureCorrection Attack,
        NatureCorrection Defense,
        NatureCorrection SpAttack,
        NatureCorrection SpDefense,
        NatureCorrection Speed)
        : StaticInfo(Key, Id)
    {
        /// <summary>
        /// こうげきのせいかく補正を取得します。
        /// </summary>
        public NatureCorrection Attack { get; init; } = Attack;

        /// <summary>
        /// ぼうぎょのせいかく補正を取得します。
        /// </summary>
        public NatureCorrection Defense { get; init; } = Defense;

        /// <summary>
        /// とくこうのせいかく補正を取得します。
        /// </summary>
        public NatureCorrection SpAttack { get; init; } = SpAttack;

        /// <summary>
        /// とくぼうのせいかく補正を取得します。
        /// </summary>
        public NatureCorrection SpDefense { get; init; } = SpDefense;

        /// <summary>
        /// すばやさのせいかく補正を取得します。
        /// </summary>
        public NatureCorrection Speed { get; init; } = Speed;
    }
}
