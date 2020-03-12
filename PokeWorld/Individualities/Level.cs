using System;

namespace PokeWorld.Individualities
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
        /// レベルを取得します。
        /// </summary>
        public int Value { get; private set; }

        /// <summary>
        /// 最小レベルであることを表す値を取得します。
        /// </summary>
        public bool IsMin => Value == MinValue;

        /// <summary>
        /// 最大レベルであることを表す値を取得します。
        /// </summary>
        public bool IsMax => Value == MaxValue;

        /// <summary>
        /// <see cref="Level"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="value">レベル。</param>
        public Level(int value)
        {
            if (value < MinValue || value > MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value,
                    $"レベルの範囲は {MinValue} ～ {MaxValue} です。");
            }
            Value = value;
        }

        /// <summary>
        /// 次のレベルを取得します。
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">最大レベルの場合に呼び出すとスローされます。</exception>
        public Level GetNext()
        {
            if (IsMax) { throw new InvalidOperationException("最大レベルです。"); }

            return new Level(Value + 1);
        }

        /// <summary>
        /// レベルをそれと等価な文字列の値に変換します。
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Value.ToString();
    }
}