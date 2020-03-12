using System;

namespace PokeWorld.Individualities
{
    /// <summary>
    /// 種族値を表します。
    /// </summary>
    public class BaseStatistic<T>
        where T : IStatistic
    {
        /// <summary>種族値の最小値</summary>
        private const int MinValue = 0;
        /// <summary>種族値の最小値</summary>
        private const int MaxValue = 255;

        /// <summary>
        /// 種族値を取得します。
        /// </summary>
        public int Value { get; private set; }

        /// <summary>
        /// <see cref="BaseStatistic"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="value">種族値。</param>
        public BaseStatistic(int value)
        {
            if (value < MinValue || value > MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value,
                    $"種族値の範囲は {MinValue} ～ {MaxValue} です。");
            }
            Value = value;
        }
    }
}
