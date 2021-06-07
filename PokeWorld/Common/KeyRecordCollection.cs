using System;
using System.Collections;
using System.Collections.Generic;

namespace PokeWorld.Common
{
    /// <summary>
    /// <see cref="KeyRecord"/> オブジェクトのインスタンスをキー名で参照するための読み取り専用コレクションです。
    /// </summary>
    /// <typeparam name="T"><see cref="KeyRecord"/> 型から派生する要素の型。</typeparam>
    public class KeyRecordCollection<T> : IEnumerable<T> where T : KeyRecord
    {
        /// <summary>キー名とそれに対応する <see cref="KeyRecord"/> オブジェクトのマップ</summary>
        private readonly IReadOnlyDictionary<string, T> keyRecordMap;

        /// <summary>
        /// <see cref="KeyRecordCollection{T}"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="collection">コレクションに追加する <see cref="KeyRecord"/> オブジェクトのコレクション。</param>
        /// <exception cref="ArgumentException"><paramref name="collection"/> に重複するキー名の <see cref="KeyRecord"/> オブジェクトが存在する場合にスローされます。</exception>
        public KeyRecordCollection(IEnumerable<T> collection)
        {
            var keys = new SortedDictionary<string, T>();

            foreach(T item in collection)
            {
                if (keys.ContainsKey(item.Key))
                {
                    throw new ArgumentException($"{nameof(KeyRecord)} オブジェクト '{nameof(T)}' のキー名 '{item.Key}' は既に存在します。重複しないキー名を使用してください。");
                }
                keys.Add(item.Key, item);
            }

            keyRecordMap = keys;
        }

        /// <summary>
        /// 指定したキー名のインスタンスを取得します。
        /// </summary>
        /// <param name="key">取得するインスタンスのキー名。</param>
        public T this[string key]
        {
            get
            {
                if (!keyRecordMap.ContainsKey(key))
                {
                    throw new IndexOutOfRangeException($"{nameof(KeyRecord)} オブジェクト '{nameof(T)}' にキー名 '{key}' は存在しません。");
                }
                return keyRecordMap[key];
            }
        }

        /// <summary>
        /// コレクションをキー名の昇順で反復処理する列挙子を返します。
        /// </summary>
        /// <returns>コレクションの列挙子。</returns>
        public IEnumerator<T> GetEnumerator() => keyRecordMap.Values.GetEnumerator();

        /// <summary>
        /// コレクションをキー名の昇順で反復処理する列挙子を返します。
        /// </summary>
        /// <returns>コレクションの列挙子。</returns>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
