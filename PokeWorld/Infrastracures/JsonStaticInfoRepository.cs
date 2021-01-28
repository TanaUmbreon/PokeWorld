using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using PokeWorld.Models;
using PokeWorld.Models.Static;
using PokeWorld.Repositories;

namespace PokeWorld.Infrastracures
{
    /// <summary>
    /// JSON ファイルで構成された静的データへの操作を実装します。
    /// </summary>
    public class JsonStaticInfoRepository : IStaticInfoRepository
    {
        public StaticInfoCollection<NatureStaticInfo> Natures { get; }

        /// <summary>
        /// <see cref="JsonStaticInfoRepository"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="direcotoryPath">静的データ フォルダのパス。</param>
        public JsonStaticInfoRepository(string direcotoryPath)
        {
            var directory = new DirectoryInfo(direcotoryPath);
            if (!directory.Exists)
            {
                throw new DirectoryNotFoundException($"静的データ フォルダ '{directory.FullName}' は存在しません。");
            }

            JsonNatureStaticInfo obj = Load<JsonNatureStaticInfo>(Path.Combine(directory.FullName, "Natures.json"), new EnumerationJsonConverter<NatureCorrection>());
            Natures = new StaticInfoCollection<NatureStaticInfo>(obj.Natures);
        }

        private static T Load<T>(string filePath, params JsonConverter[] converters)
        {
            var file = new FileInfo(filePath);
            if (!file.Exists)
            {
                throw new FileNotFoundException($"静的データ ファイル '{file.FullName}' は存在しません。");
            }

            return JsonConvert.DeserializeObject<T>(File.ReadAllText(file.FullName), converters)
                ?? throw new InvalidCastException();
        }

        private class JsonNatureStaticInfo
        {
            public IEnumerable<NatureStaticInfo> Natures { get; set; } = Array.Empty<NatureStaticInfo>();
        }
    }
}
