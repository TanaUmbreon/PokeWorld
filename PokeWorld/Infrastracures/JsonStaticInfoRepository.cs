using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokeWorld.Models.Static;
using PokeWorld.Repositories;
using Newtonsoft.Json;
using System.IO;

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

            var file = new FileInfo(Path.Combine(directory.FullName, "Natures.json"));
            if (!file.Exists)
            {
                throw new FileNotFoundException($"静的データ ファイル '{file.FullName}' は存在しません。");
            }
            JsonNatureStaticInfo obj = JsonConvert.DeserializeObject<JsonNatureStaticInfo>(File.ReadAllText(file.FullName));
            Natures = new StaticInfoCollection<NatureStaticInfo>(obj.Natures);
        }

        internal class JsonNatureStaticInfo
        {
            public IEnumerable<NatureStaticInfo> Natures { get; set; } = Array.Empty<NatureStaticInfo>();
        }

        internal class JsonStaticInfo<T> where T : StaticInfo
        {
            public IEnumerable<T> Items { get; set; } = Array.Empty<T>();
        }
    }
}
