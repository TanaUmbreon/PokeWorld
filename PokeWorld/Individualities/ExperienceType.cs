using System;
using PokeWorld.DomainSupport;

namespace PokeWorld.Individualities
{
    /// <summary>
    /// 経験値タイプを表します。
    /// </summary>
    public sealed class ExperienceType : Enumeration
    {
        /// <summary>60万タイプ</summary>
        public static readonly ExperienceType Erratic = new ExperienceType(
            id: 0,
            name: "60万タイプ",
            formula: level => level.Value switch
            {
                int lv when lv <= 50 =>
                    new Experience(Floor(Pow(lv, 3) * (100 - lv) / 50.0)),
                int lv when lv <= 68 =>
                    new Experience(Floor(Pow(lv, 3) * (150 - lv) / 100.0)),
                int lv when lv <= 98 =>
                    new Experience(Floor(Pow(lv, 3) * Floor((1911 - (10 * lv)) / 3.0) / 500.0)),
                int lv =>
                    new Experience(Floor(Pow(lv, 3) * (160 - lv) / 100.0)),
            });

        /// <summary>80万タイプ</summary>
        public static readonly ExperienceType Fast = new ExperienceType(
            id: 1,
            name: "80万タイプ",
            formula: lv => new Experience(Floor(4 * Pow(lv.Value, 3) / 5.0))
            );

        /// <summary>100万タイプ</summary>
        public static readonly ExperienceType MediumFast = new ExperienceType(
            id: 2,
            name: "100万タイプ",
            formula: lv => new Experience(Pow(lv.Value, 3))
            );

        /// <summary>105万タイプ</summary>
        public static readonly ExperienceType MediumSlow = new ExperienceType(
            id: 3,
            name: "105万タイプ",
            formula: lv => new Experience(
                + Floor(6 * Pow(lv.Value, 3) / 5.0)
                - 15 * Pow(lv.Value, 2)
                + 100 * lv.Value
                - 140
                )
            );

        /// <summary>125万タイプ</summary>
        public static readonly ExperienceType Slow = new ExperienceType(
            id: 4,
            name: "125万タイプ",
            formula: lv => new Experience(Floor(5 * Pow(lv.Value, 3) / 4.0))
            );

        /// <summary>164万タイプ</summary>
        public static readonly ExperienceType Fluctuating = new ExperienceType(
            id: 5,
            name: "164万タイプ",
            formula: level => level.Value switch
            {
                int lv when lv <= 15 =>
                    new Experience(Floor(Pow(lv, 3) * (24 + Floor((lv + 1) / 3.0)) / 50.0)),
                int lv when lv <= 36 =>
                    new Experience(Floor(Pow(lv, 3) * (14 + lv) / 50.0)),
                int lv =>
                    new Experience(Floor(Pow(lv, 3) * (32 + Floor(lv / 2.0)) / 50.0)),
            });

        /// <summary>
        /// 指定した数以下の数のうち、最大の整数値を返します。
        /// </summary>
        /// <param name="d">倍精度浮動小数点数。</param>
        /// <returns><paramref name="d"/> 以下の最大の整数値。</returns>
        private static int Floor(double d) => Convert.ToInt32(Math.Floor(d));

        /// <summary>
        /// 指定の数値を指定した値で累乗した整数値を返します。
        /// </summary>
        /// <param name="x">累乗対象の整数値。</param>
        /// <param name="y">累乗を指定する整数値。</param>
        /// <returns>数値 <paramref name="x"/> を <paramref name="y"/> で累乗した値。</returns>
        private static int Pow(int x, int y) => Convert.ToInt32(Math.Pow(x, y));

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
            base(id, name) => this.formula = formula;

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
