using System;

namespace PokeWorld.Statistics
{
    /// <summary>
    /// レベルを表します。
    /// </summary>
    public class Level
    {
        /// <summary>レベルの最小値</summary>
        private const int MinValue = 1;
        /// <summary>レベルの最大値</summary>
        private const int MaxValue = 100;

        /// <summary>
        /// レベルの値を取得します。
        /// </summary>
        public int Value { get; private set; }

        /// <summary>
        /// <see cref="Level"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="value">レベルの値。</param>
        public Level(int value)
        {
            if (value < MinValue || value > MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value,
                    $"レベルの値の範囲は {MinValue} ～ {MaxValue} です。");
            }
            Value = value;
        }

        /// <summary>
        /// レベルの値をそれと等価な文字列の値に変換します。
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Value.ToString();
    }
}