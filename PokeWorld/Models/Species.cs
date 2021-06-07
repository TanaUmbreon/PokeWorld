using System.Collections.Generic;
using PokeWorld.Common;

namespace PokeWorld.Models
{
    /// <summary>
    /// 種族情報を格納するレコードです。
    /// </summary>
    public record Species(
        string Key,
        PokedexNumberSet PokedexNumber,
        IEnumerable<Type> Types,
        decimal Height,
        decimal Weight,
        IEnumerable<string> Abilities,
        BaseStatsSet BaseStats,
        IEnumerable<Evolution> Evolutions,
        IEnumerable<EggGroup> EggGroups,
        int EggCycle,
        BasePointsSet BasePointsYield,
        int BaseExperienceYield,
        int BaseFriendship
        ) : KeyRecord(Key)
    {
        /// <summary>
        /// 図鑑番号を取得します。
        /// </summary>
        public PokedexNumberSet PokedexNumber { get; init; } = PokedexNumber;

        /// <summary>
        /// タイプを取得します。
        /// </summary>
        public IEnumerable<Type> Types { get; init; } = Types;

        /// <summary>
        /// メートル単位の高さを取得します。
        /// </summary>
        public decimal Height { get; init; } = Height;

        /// <summary>
        /// メートル単位の重さを取得します。
        /// </summary>
        public decimal Weight { get; init; } = Weight;

        /// <summary>
        /// 特性を取得します。
        /// </summary>
        public IEnumerable<string> Abilities { get; init; } = Abilities;

        /// <summary>
        /// 種族値を取得します。
        /// </summary>
        public BaseStatsSet BaseStats { get; init; } = BaseStats;

        /// <summary>
        /// 進化情報を取得します。
        /// </summary>
        public IEnumerable<Evolution> Evolutions { get; init; } = Evolutions;

        /// <summary>
        /// タマゴ グループを取得します。
        /// </summary>
        public IEnumerable<EggGroup> EggGroups { get; init; } = EggGroups;

        /// <summary>
        /// タマゴの孵化にかかるサイクル数を取得します。
        /// </summary>
        public int EggCycle { get; init; } = EggCycle;

        /// <summary>
        /// 獲得基礎ポイント (努力値) を取得します。
        /// </summary>
        public BasePointsSet BasePointsYield { get; init; } = BasePointsYield;

        /// <summary>
        /// 基礎経験値を取得します。
        /// </summary>
        public int BaseExperienceYield { get; init; } = BaseExperienceYield;

        /// <summary>
        /// 初期なかよし度を取得します。
        /// </summary>
        public int BaseFriendship { get; init; } = BaseFriendship;
    }
}
