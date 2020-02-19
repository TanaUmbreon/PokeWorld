using System;
using System.Collections.Generic;
using System.Text;

namespace PokeWorld.Statistics
{
    /// <summary>
    /// ステータスを表します。
    /// </summary>
    public class Statistic
    {
        /// <summary>
        /// レベルの値を取得します。
        /// </summary>
        public Level Level { get; private set; }

        /// <summary>
        /// <see cref="Statistic"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="level">レベル。</param>
        public Statistic(Level level)
        {
            Level = level;
        }

    }
}
