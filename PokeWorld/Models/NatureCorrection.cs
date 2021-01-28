using System.Diagnostics;
using PokeWorld.Common;

namespace PokeWorld.Models
{
    /// <summary>
    /// せいかく補正を表します。
    /// </summary>
    [DebuggerDisplay(@"{nameof(NatureCorrection),nq}.{Key,nq} (x{Rate})")]
    public sealed class NatureCorrection : Enumeration
    {
        /// <summary>無補正 (1.0 倍)</summary>
        public static readonly NatureCorrection NoChange = new NatureCorrection(
            id: 0,
            key: "NoChange",
            rate: 1.0);

        /// <summary>上昇補正 (1.1 倍)</summary>
        public static readonly NatureCorrection Increased = new NatureCorrection(
            id: 1,
            key: "Increased",
            rate: 1.1);

        /// <summary>下降補正 (0.9 倍)</summary>
        public static readonly NatureCorrection Decreased = new NatureCorrection(
            id: 2,
            key: "Decreased",
            rate: 0.9);

        #region 列挙型クラスのインスタンス メンバ

        /// <summary>
        /// 補正倍率を取得します。
        /// </summary>
        public double Rate { get; init; }

        /// <summary>
        /// <see cref="NatureCorrection"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="id">せいかく補正を一意に特定する整数型識別子。</param>
        /// <param name="key">せいかく補正を一意に特定する文字列型識別子。</param>
        /// <param name="rate">補正倍率。</param>
        private NatureCorrection(int id, string key, double rate) :
            base(id, key)
        {
            Rate = rate;
        }

        #endregion
    }
}
