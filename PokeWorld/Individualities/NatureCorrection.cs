using PokeWorld.DomainSupport;

namespace PokeWorld.Individualities
{
    /// <summary>
    /// せいかく補正を表します。
    /// </summary>
    public sealed class NatureCorrection : Enumeration
    {
        /// <summary>無補正 (1.0 倍)</summary>
        public static readonly NatureCorrection NoChange = new NatureCorrection(
            id: 0,
            name: "無補正",
            rate: 1.0
            );
        /// <summary>上昇補正 (1.1 倍)</summary>
        public static readonly NatureCorrection Increased = new NatureCorrection(
            id: 1,
            name: "上昇補正",
            rate: 1.1
            );
        /// <summary>下降補正 (0.9 倍)</summary>
        public static readonly NatureCorrection Decreased = new NatureCorrection(
            id: 2,
            name: "下降補正",
            rate: 0.9
            );

        #region 列挙型クラスのインスタンス メンバ

        /// <summary>
        /// 補正倍率を取得します。
        /// </summary>
        public double Rate { get; private set; }

        /// <summary>
        /// <see cref="NatureCorrection"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="id">せいかく補正を一意に特定する為の識別子。</param>
        /// <param name="name">せいかく補正名。</param>
        /// <param name="rate">補正倍率。</param>
        private NatureCorrection(int id, string name, double rate) :
            base(id, name)
        {
            Rate = rate;
        }

        #endregion
    }
}
