using System;
using PokeWorld.DomainSupport;

namespace PokeWorld.Statistics
{
    /// <summary>
    /// 経験値タイプを表します。
    /// </summary>
    public class ExperienceType : Enumeration
    {
        /// <summary>105万タイプ</summary>
        public static readonly ExperienceType MediumSlow = new ExperienceType(
            id: 3,
            name: "105万タイプ",
            formula: lv => new Experience(
                Floor(6 * (lv.Value ^ 3) / 5.0)
                - 15 * (lv.Value ^ 2)
                + 100 * lv.Value
                - 140
            ));

        /// <summary>
        /// 指定した数以下の数のうち、最大の整数値を返します。
        /// </summary>
        /// <param name="d">倍精度浮動小数点数。</param>
        /// <returns><paramref name="d"/> 以下の最大の整数値。</returns>
        private static int Floor(double d) => Convert.ToInt32(Math.Floor(d));

        #region 列挙型クラスのインスタンス メンバ

        /// <summary>指定したレベルに到達する為に必要な累計経験値を算出する計算式</summary>
        private readonly Func<Level, Experience> formula;

        /// <summary>
        /// <see cref="ExperienceType"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="id">経験値タイプを一意に特定する為の識別子。</param>
        /// <param name="name">経験値タイプ名。</param>
        /// <param name="formula">指定したレベルに到達する為に必要な累計経験値を算出する計算式。</param>
        private ExperienceType(int id, string name, Func<Level, Experience> formula) :
            base(id, name)
        {
            this.formula = formula;
        }

        /// <summary>
        /// 指定したレベルに到達する為に必要な累計経験値を計算します。
        /// </summary>
        /// <param name="level">レベル。</param>
        /// <returns>累計経験値。</returns>
        public Experience CalculateTotalExp(Level level) =>
            level.IsMin ? Experience.Zero : formula(level);

        #endregion
    }
}
