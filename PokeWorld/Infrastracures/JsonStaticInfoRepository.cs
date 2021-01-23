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
    /// 
    /// </summary>
    public class JsonStaticInfoRepository : IStaticInfoRepository
    {
        public StaticInfoCollection<NatureStaticInfo> Natures { get; }

        /// <summary>
        /// <see cref="JsonStaticInfoRepository"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="path"></param>
        public JsonStaticInfoRepository(string path)
        {
            throw new NotImplementedException();
        }
    }
}
