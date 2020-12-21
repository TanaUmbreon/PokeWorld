using System;
using System.Collections.Generic;

namespace PokeWorld.DomainSupport
{
    /// <summary>
    /// 疑似乱数ジェネレーターを表します。
    /// </summary>
    public class Randomizer : IRandomizer
    {
        private readonly Random random = new Random();

        /// <summary>
        /// <see cref="Randomizer"/> の新しいインスタンスを生成します。
        /// </summary>
        public Randomizer() { }

        public int Next(int minValue, int maxValue) => random.Next(minValue, maxValue);

        public int Next(int maxValue) => Next(0, maxValue);

        public bool NextBoolean() => Next(0, 2) == 1;

        public T? SelectOne<T>(IList<T> source)
        {
            if (source == null) { throw new ArgumentNullException(nameof(source)); }
            if (source.Count <= 0) { throw new ArgumentException($"引数 {nameof(source)} に要素が空のコレクションは指定できません。", nameof(source)); }

            return source[Next(0, source.Count)];
        }
    }
}
