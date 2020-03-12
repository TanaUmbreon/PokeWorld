using System;
using System.Collections.Generic;
using System.Text;

namespace PokeWorld.Individualities
{
    /// <summary>
    /// ポケモンを表します。
    /// </summary>
    public class Pokemon
    {
        /// <summary>
        /// 種族を取得します。
        /// </summary>
        public Species Species { get; private set; }

        /// <summary>
        /// レベルを取得します。
        /// </summary>
        public Level Level { get; private set; }

        /// <summary>
        /// 累計経験値を取得します。
        /// </summary>
        public Experience TotalExp { get; private set; }

        /// <summary>
        /// 次のレベルまでの必要経験値を取得します。
        /// </summary>
        public Experience RequiredExpToNextLevel { get; private set; }

        /// <summary>
        /// せいかくを取得します。
        /// </summary>
        public Nature Nature { get; private set; }

        ///// <summary>
        ///// 能力値を取得します。
        ///// </summary>
        //public StatisticSet<Statistic> Statistics { get; private set; }

        ///// <summary>
        ///// 努力値 (基礎ポイント) を取得します。
        ///// </summary>
        //public StatisticSet<EffortValue> EffortValues { get; private set; }

        ///// <summary>
        ///// 個体値を取得します。
        ///// </summary>
        //public StatisticSet<IndividualValue> IndividualValues { get; private set; }

        /// <summary>
        /// <see cref="Pokemon"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="species">種族。</param>
        /// <param name="level">レベル。</param>
        /// <param name="natureGeneratror">せいかく生成アルゴリズム。</param>
        public Pokemon(Species species, Level level, INatureGenerator natureGeneratror)
        {
            Species = species;
            Level = level;
            TotalExp = species.ExpType.CalculateTotalExp(level);
            RequiredExpToNextLevel = CalculateRequiredExpToNextLevel(level, species.ExpType, TotalExp);
            Nature = natureGeneratror.Generate();
        }

        /// <summary>
        /// 現在のインスタンスの経験値タイプ、レベル、累計経験値を元に、
        /// 次のレベルまでの必要経験値を計算します。
        /// </summary>
        /// <param name="level">現在のレベル。</param>
        /// <param name="expType">経験値タイプ。</param>
        /// <param name="totalExp">現在の累計経験値。</param>
        /// <returns>次のレベルまでの必要経験値。</returns>
        private Experience CalculateRequiredExpToNextLevel(Level level, ExperienceType expType, Experience totalExp)
        {
            if (level.IsMax) { return Experience.Zero; }

            Experience next = expType.CalculateTotalExp(level.GetNext());
            return next.Subtract(totalExp);
        }
    }
}
