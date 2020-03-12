using PokeWorld.DomainSupport;

namespace PokeWorld.Individualities
{
    /// <summary>
    /// ポケモンの種族を表します。
    /// </summary>
    public sealed class Species : Enumeration
    {
        /// <summary>フシギダネ</summary>
        public static readonly Species Bulbasaur = new Species(
            id: 1,
            name: "フシギダネ",
            ExperienceType.MediumSlow,
            new BaseStatistics(
                new BaseStatistic<HitPoints>(45),
                new BaseStatistic<Attack>(49),
                new BaseStatistic<Defense>(49),
                new BaseStatistic<SpecialAttack>(65),
                new BaseStatistic<SpecialDefense>(65),
                new BaseStatistic<Speed>(45)
                )
            );

        #region 列挙型クラスのインスタンス メンバ

        /// <summary>
        /// 経験値タイプを取得します。
        /// </summary>
        public ExperienceType ExpType { get; private set; }

        /// <summary>
        /// 種族値を取得します。
        /// </summary>
        public BaseStatistics BaseStats { get; private set; }

        /// <summary>
        /// <see cref="Species"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="id">ポケモンの種族を一意に特定する為の識別子。</param>
        /// <param name="name">種族名。</param>
        /// <param name="expType">経験値タイプ。</param>
        /// <param name="baseStats">種族値。</param>
        private Species(int id, string name, ExperienceType expType, BaseStatistics baseStats) :
            base(id, name)
        {
            ExpType = expType;
            BaseStats = baseStats;
        }

        #endregion
    }
}
