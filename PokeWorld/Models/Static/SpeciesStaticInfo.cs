using System;
using System.Collections.Generic;
using System.Linq;

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
        /// <see cref="SpeciesStaticInfo"/> の新しいインスタンスを生成します。
        /// </summary>
        public SpeciesStaticInfo(string key, PokedexNumberStaticInfo pokedexNumber)
        {
            Key = key;
            PokedexNumber = pokedexNumber;
        }

        #region データ参照をサポートする為のメソッド

        /// <summary>
        /// 全国図鑑番号を取得します。
        /// </summary>
        public int GetNationalPokedexNumber() => PokedexNumber.National;

        #endregion
    }
}
