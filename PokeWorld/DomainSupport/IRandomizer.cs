using System;
using System.Collections.Generic;

namespace PokeWorld.DomainSupport
{
    /// <summary>
    /// 疑似乱数ジェネレーターを実装します。
    /// </summary>
    public interface IRandomizer
    {
        /// <summary>
        /// <paramref name="minValue"/> 以上 <paramref name="maxValue"/> 未満のランダムな整数を返します。
        /// </summary>
        /// <param name="minValue">返される乱数の下限値。返される乱数にこの値は含まれます。</param>
        /// <param name="maxValue">返される乱数の上限値。返される乱数にこの値は含まれません。</param>
        /// <returns><param name="minValue"> 以上 <paramref name="maxValue"/> 未満の 32 ビット符号付整数。</returns>
        int Next(int minValue, int maxValue);

        /// <summary>
        /// 0 以上 <paramref name="maxValue"/> 未満のランダムな整数を返します。
        /// </summary>
        /// <param name="maxValue">返される乱数の上限値。返される乱数にこの値は含まれません。</param>
        /// <returns>0 以上 <paramref name="maxValue"/> 未満の 32 ビット符号付整数。</returns>
        int Next(int maxValue);

        /// <summary>
        /// true または false のどちらかをランダムに返します。
        /// </summary>
        /// <returns>true または false。</returns>
        bool NextBoolean();

        /// <summary>
        /// 指定したリスト コレクションからランダムに要素を一つ選択して返します。リスト コレクションが空の場合は例外をスローします。
        /// </summary>
        /// <typeparam name="T">リスト コレクションの要素および戻り値の型。</typeparam>
        /// <param name="source">選択対象の要素が格納されたリスト コレクション。</param>
        /// <returns><paramref name="source"/> から選択された一つの要素。<paramref name="source"/> が空の場合は null。</returns>
        /// <exception cref="ArgumentException"><paramref name="source"/> の要素が空の場合にスローされます。</exception>
        T SelectOne<T>(IList<T> source);
    }
}
