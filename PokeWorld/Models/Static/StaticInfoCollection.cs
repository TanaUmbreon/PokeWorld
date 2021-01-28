using System;
using System.Collections;
using System.Collections.Generic;

namespace PokeWorld.Models.Static
{
    /// <summary>
    /// 静的データを ID またはキー名で参照するための読み取り専用コレクションです。
    /// </summary>
    /// <typeparam name="T">静的データの型。</typeparam>
    public class StaticInfoCollection<T> : IEnumerable<T> where T : StaticInfo
    {
        private readonly IReadOnlyDictionary<int, T> idList;
        private readonly IReadOnlyDictionary<string, T> keyList;

        /// <summary>
        /// <see cref="StaticInfoCollection"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="sources">コレクションに追加する静的データのソース。</param>
        /// <exception cref="ArgumentNullException"><paramref name="sources"/> が null です。</exception>
        /// <exception cref="ArgumentException"><paramref name="sources"/> に重複する ID またはキー名が存在します。</exception>
        internal StaticInfoCollection(IEnumerable<T> sources)
        {
            if (sources == null) { throw new ArgumentNullException(nameof(sources)); }

            var ids = new SortedDictionary<int, T>();
            var keys = new SortedDictionary<string, T>();

            foreach(T source in sources)
            {
                if (ids.ContainsKey(source.Id))
                {
                    throw new ArgumentException($"静的データ {nameof(T)} の ID ({source.Id}) は既に存在します。重複しない値を使用してください。");
                }
                if (keys.ContainsKey(source.Key))
                {
                    throw new ArgumentException($"静的データ {nameof(T)} のキー名 '{source.Key}' は既に存在します。重複しない名前を使用してください。");
                }

                ids.Add(source.Id, source);
                keys.Add(source.Key, source);
            }

            idList = ids;
            keyList = keys;
        }

        /// <summary>
        /// 指定した ID の静的データを取得します。
        /// </summary>
        /// <param name="id">取得する静的データの ID。</param>
        public T this[int id]
        {
            get
            {
                if (!idList.ContainsKey(id))
                {
                    throw new IndexOutOfRangeException($"静的データ {nameof(T)} に ID ({id}) は存在しません。");
                }
                return idList[id];
            }
        }

        /// <summary>
        /// 指定したキー名の静的データを取得します。
        /// </summary>
        /// <param name="key">取得する静的データのキー名。</param>
        public T this[string key]
        {
            get
            {
                if (!keyList.ContainsKey(key))
                {
                    throw new IndexOutOfRangeException($"静的データ {nameof(T)} にキー名 '{key}' は存在しません。");
                }
                return keyList[key];
            }
        }

        /// <summary>
        /// 静的データを ID の昇順で反復処理する列挙子を返します。
        /// </summary>
        /// <returns>静的データの列挙子。</returns>
        public IEnumerator<T> GetEnumerator() => idList.Values.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
