using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using PokeWorld.Common;
using PokeWorld.Models;
using PokeWorld.Repositories;

namespace PokeWorld.Infrastracures
{
    /// <summary>
    /// JSON 形式で定義された静的データ ファイルへの物理的な操作を実装します。
    /// </summary>
    public class JsonStaticRepository : IStaticRepository
    {
        public KeyRecordCollection<Species> Species { get; }

        /// <summary>
        /// <see cref="JsonStaticRepository"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="staticRootDirectoryPath">JSON ファイル形式の静的データが格納されたルート フォルダーのパス。</param>
        public JsonStaticRepository(string staticRootDirectoryPath)
        {
            var directory = new DirectoryInfo(staticRootDirectoryPath);
            if (!directory.Exists)
            {
                throw new DirectoryNotFoundException($"静的データのルート フォルダー '{directory.FullName}' は存在しません。");
            }

            Species = LoadAsKeyRecordCollection<Species>(Path.Combine(directory.FullName, "Natures.json"));
        }

        /// <summary>
        /// パス指定した JSON 形式の静的データ ファイルを読み込み、 <see cref="KeyRecordCollection{T}"/> に変換して返します。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath">読み込む JSON 形式の静的データ ファイルのパス。</param>
        /// <param name="converters"></param>
        /// <returns></returns>
        private static KeyRecordCollection<T> LoadAsKeyRecordCollection<T>(string filePath, params JsonConverter[] converters) where T : KeyRecord
        {
            var file = new FileInfo(filePath);
            if (!file.Exists)
            {
                throw new FileNotFoundException($"静的データ '{nameof(T)}' のファイル '{file.FullName}' は存在しません。");
            }

            var a = JsonConvert.DeserializeObject<JsonKeyRecord<T>>(File.ReadAllText(file.FullName), converters)
                ?? throw new InvalidCastException();

            return new KeyRecordCollection<T>(a.Items);
        }

        private class JsonKeyRecord<T> where T : KeyRecord
        {
            public IEnumerable<T> Items { get; set; } = Array.Empty<T>();
        }
    }
}
