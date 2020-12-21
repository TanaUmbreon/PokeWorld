using System;
using System.Linq;
using PokeWorld.Common;

namespace PokeWorld.Individualities.Generators
{
    /// <summary>
    /// 全せいかくから均一な確率でランダムにせいかくを生成するアルゴリズムです。
    /// </summary>
    public sealed class RandomNatureGenerator : INatureGenerator
    {
        #region 単一インスタンス

        /// <summary>このクラスの単一のインスタンス</summary>
        private static RandomNatureGenerator? instance;

        /// <summary>
        /// このクラスの単一のインスタンスを取得します。
        /// </summary>
        public static RandomNatureGenerator Instance => instance ??= new RandomNatureGenerator();

        /// <summary>
        /// <see cref="RandomNatureGenerator"/> の新しいインスタンスを生成します。
        /// </summary>
        private RandomNatureGenerator() { }

        #endregion

        /// <summary>全せいかくの配列</summary>
        private readonly Nature[] natures = Enumeration.GetAll<Nature>().ToArray();
        /// <summary>乱数生成オブジェクト</summary>
        private readonly Random random = new Random();

        /// <summary>
        /// 全せいかくから均一な確率でランダムに生成し返します。
        /// </summary>
        /// <returns>せいかく。</returns>
        public Nature Generate() => natures[random.Next(natures.Length)];
    }
}
