using System;
using System.Collections.Generic;
using System.Text;

namespace PokeWorld.Statistics
{
    /// <summary>
    /// レベルおよび経験値に対する操作を提供します。
    /// </summary>
    public class LevelExperienceControler
    {
        /// <summary>
        /// 経験値タイプを取得します。
        /// </summary>
        public ExperienceType ExpType { get; private set; }

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
        /// 経験値タイプとレベルを指定して
        /// <see cref="LevelExperienceControler"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="expType"></param>
        /// <param name="level"></param>
        public LevelExperienceControler(ExperienceType expType, Level level)
        {
            ExpType = expType;
            Level = level;
            TotalExp = expType.CalculateTotalExp(level);
            RequiredExpToNextLevel = CalculateRequiredExpToNextLevel();
        }

        /// <summary>
        /// 現在のインスタンスの経験値タイプ、レベル、累計経験値を元に、
        /// 次のレベルまでの必要経験値を計算します。
        /// </summary>
        /// <returns>次のレベルまでの必要経験値。</returns>
        private Experience CalculateRequiredExpToNextLevel()
        {
            if (Level.IsMax) { return Experience.Zero; }
            
            Experience next = ExpType.CalculateTotalExp(Level.GetNext());
            return next.Subtract(TotalExp);
        }
    }
}
