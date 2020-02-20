using PokeWorld.DomainSupport;

namespace PokeWorld.Statistics
{
    /// <summary>
    /// ポケモンの種族を表します。
    /// </summary>
    public class Species : Enumeration
    {
        /// <summary>フシギダネ</summary>
        public static readonly Species Bulbasaur = new Species(
            id: 1,
            name: "フシギダネ",
            expType: ExperienceType.MediumSlow);

        #region 列挙型クラスのインスタンス メンバ

        /// <summary>
        /// 経験値タイプを取得します。
        /// </summary>
        public ExperienceType ExpType { get; private set; }

        /// <summary>
        /// <see cref="Species"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="id">ポケモンの種族を一意に特定する為の識別子。</param>
        /// <param name="name">種族名。</param>
        /// <param name="expType">経験値タイプ。</param>
        private Species(int id, string name, ExperienceType expType) :
            base(id, name)
        {
            ExpType = expType;
        }

        #endregion
    }
}
