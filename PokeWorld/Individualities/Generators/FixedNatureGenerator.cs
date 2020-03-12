namespace PokeWorld.Individualities.Generators
{
    /// <summary>
    /// 任意に固定されたせいかくを生成するアルゴリズムです。
    /// </summary>
    public class FixedNatureGenerator : INatureGenerator
    {
        /// <summary>生成するせいかく</summary>
        private readonly Nature nature;

        /// <summary>
        /// <see cref="FixedNatureGenerator"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="nature">生成するせいかく。</param>
        public FixedNatureGenerator(Nature nature) => this.nature = nature;

        /// <summary>
        /// 任意に固定されたせいかくを生成し返します。
        /// </summary>
        /// <returns>せいかく。</returns>
        public Nature Generate() => nature;
    }
}
