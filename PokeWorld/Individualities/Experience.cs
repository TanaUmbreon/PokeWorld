using System;

namespace PokeWorld.Individualities
{
    /// <summary>
    /// 経験値を表します。
    /// </summary>
    public class Experience
    {
        /// <summary>経験値の最小値</summary>
        private const int MinValue = 0;
        /// <summary>経験値の最小値</summary>
        private const int MaxValue = int.MaxValue;

        /// <summary>経験値ゼロを表すインスタンス</summary>
        public static readonly Experience Zero = new(0);

        /// <summary>
        /// 経験値を取得します。
        /// </summary>
        public int Value { get; private set; }

        /// <summary>
        /// <see cref="Experience"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="value">経験値。</param>
        public Experience(int value)
        {
            if (value < MinValue || value > MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value,
                    $"経験値の範囲は {MinValue} ～ {MaxValue} です。");
            }
            Value = value;
        }

        /// <summary>
        /// 現在の経験値から指定した経験値を引いた差を計算します。
        /// </summary>
        /// <param name="exp">引く経験値。</param>
        /// <returns>現在の経験値から指定した経験値を引いた差。</returns>
        public Experience Subtract(Experience exp)
        {
            if (Value - exp.Value < MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(exp), exp,
                    $"差を計算すると経験値が負の値になります。");
            }
            return new Experience(Value - exp.Value);
        }

        /// <summary>
        /// 経験値をそれと等価な文字列の値に変換します。
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Value.ToString();

        public override bool Equals(object? obj)
        {
            if (obj is not Experience otherValue) { return false; }

            return GetType().Equals(obj.GetType()) && Value.Equals(otherValue.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }
}
