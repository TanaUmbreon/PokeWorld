namespace PokeWorld.Models.Static
{
    /// <summary>
    /// 図鑑番号の静的データを格納します。
    /// </summary>
    public class PokedexNumberStaticInfo
    {
        /// <summary>
        /// 全国図鑑番号を取得します。
        /// </summary>
        public int National { get; init; }

        // Note: データを拡張する時
        ///// <summary>
        ///// ジョウト図鑑番号を取得します。定義されていない場合は null を返します。
        ///// </summary>
        //public int? Johto { get; init; }

        /// <summary>
        /// <see cref="PokedexNumberStaticInfo"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="national">全国図鑑番号。</param>
        public PokedexNumberStaticInfo(int national)
        {
            National = national;
        }
    }
}