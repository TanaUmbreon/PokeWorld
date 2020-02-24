using PokeWorld.DomainSupport;

namespace PokeWorld.Statistics
{
    /// <summary>
    /// せいかく補正を表します。
    /// </summary>
    public sealed class CorrectionRate : Enumeration
    {
        /// <summary>無補正 (1.0 倍)</summary>
        public static readonly CorrectionRate NoChange = new CorrectionRate(
            id: 0,
            name: "無補正",
            rate: 1.0
            );
        /// <summary>上昇補正 (1.1 倍)</summary>
        public static readonly CorrectionRate Increased = new CorrectionRate(
            id: 1,
            name: "上昇補正",
            rate: 1.1
            );
        /// <summary>下降補正 (0.9 倍)</summary>
        public static readonly CorrectionRate Decreased = new CorrectionRate(
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
        /// <see cref="CorrectionRate"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="id">せいかく補正を一意に特定する為の識別子。</param>
        /// <param name="name">せいかく補正名。</param>
        /// <param name="rate">補正倍率。</param>
        private CorrectionRate(int id, string name, double rate) :
            base(id, name)
        {
            Rate = rate;
        }

        #endregion
    }
}
