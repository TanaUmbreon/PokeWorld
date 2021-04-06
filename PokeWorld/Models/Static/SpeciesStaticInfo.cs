namespace PokeWorld.Models.Static
{
    /// <summary>
    /// 種族の静的データを格納します。
    /// </summary>
    public class SpeciesStaticInfo
    {
        /// <summary>
        /// インスタンスを一意に特定する識別子を取得します。
        /// </summary>
        public string Key { get; init; }

        /// <summary>
        /// 図鑑番号の静的データを取得します。
        /// </summary>
        public PokedexNumberStaticInfo PokedexNumber { get; init; }

        /// <summary>
        /// 種族値の静的データを取得します。
        /// </summary>
        public BaseStatsStaticInfo BaseStats { get; init; }

        /// <summary>
        /// <see cref="SpeciesStaticInfo"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="key">種族を一意に特定する識別子</param>
        /// <param name="pokedexNumber">図鑑番号の静的データ。</param>
        /// <param name="baseStats">種族値の静的データ。</param>
        public SpeciesStaticInfo(string key, PokedexNumberStaticInfo pokedexNumber, BaseStatsStaticInfo baseStats)
        {
            Key = key;
            PokedexNumber = pokedexNumber;
            BaseStats = baseStats;
        }

        #region データ参照をサポートする為のメソッド

        /// <summary>
        /// 全国図鑑番号を取得します。
        /// </summary>
        public int GetNationalPokedexNumber() => PokedexNumber.National;

        #endregion
    }
}
