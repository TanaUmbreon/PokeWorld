namespace PokeWorld.Statistics
{
    /// <summary>
    /// せいかくを生成する為のアルゴリズムです。
    /// </summary>
    public interface INatureGenerator
    {
        /// <summary>
        /// せいかくをアルゴリズムに従って生成し返します。
        /// </summary>
        /// <returns>せいかく。</returns>
        Nature Generate();
    }
}
