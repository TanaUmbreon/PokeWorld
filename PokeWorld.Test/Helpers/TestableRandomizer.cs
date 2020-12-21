using System;
using System.Collections.Generic;
using PokeWorld.Common;

namespace PokeWorld.Test.Helpers
{
    /// <summary>
    /// ユニット テスト用に使用する疑似乱数ジェネレーターを表します。
    /// <see cref="NextValueController"/> を使用することで返す値を指定することができます。
    /// </summary>
    public class TestableRandomizer : IRandomizer
    {
        private readonly NextValueController controller;

        /// <summary>
        /// <see cref="TestableRandomizer"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="controller">乱数生成の戻り値を指定するための操作オブジェクト。</param>
        public TestableRandomizer(NextValueController controller)
        {
            this.controller = controller
                ?? throw new ArgumentNullException(nameof(controller));
        }

        public int Next(int minValue, int maxValue)
        {
            if ((controller.NextInt32Value < minValue) || (controller.NextInt32Value >= maxValue))
            {
                throw new InvalidOperationException($"{minValue} 以上 {maxValue} 未満の乱数生成において、 {nameof(NextValueController)} は戻り値 {controller.NextInt32Value} を返そうとしました。");
            }
            return controller.NextInt32Value;
        }

        public int Next(int maxValue) => Next(0, maxValue);

        public bool NextBoolean() => Next(0, 2) == 1;

        public T SelectOne<T>(IList<T> source)
        {
            if (source == null) { throw new ArgumentNullException(nameof(source)); }
            if (source.Count <= 0) { throw new ArgumentException($"要素が空のコレクションは指定できません。", nameof(source)); }

            return source[Next(0, source.Count)];
        }
    }
}
