using PokeWorld.Models.Static;

namespace PokeWorld.Models
{
    /// <summary>
    /// <see cref="BattleCharacter"/> を生成するためのアルゴリズムです。
    /// </summary>
    public interface IBattleCharacterGenerator
    {
        /// <summary>
        /// 生成するキャラクターの種族データを取得します。
        /// </summary>
        /// <returns></returns>
        SpeciesStaticInfo GetSpecies();

        /// <summary>
        /// 生成するキャラクターのレベルを取得します。
        /// </summary>
        /// <returns></returns>
        public int GetLevel();

        /// <summary>
        /// 生成するキャラクターのステータス (実数値) を取得します。
        /// </summary>
        /// <returns></returns>
        public StatInfo GetStat();

        /// <summary>
        /// 生成するキャラクターの生まれつきのつよさ (個体値) を取得します。
        /// </summary>
        /// <returns></returns>
        public IndividualStrengthsInfo GetIndividualStrengths();

        /// <summary>
        /// 生成するキャラクターの基礎ポイント (努力値) を取得します。
        /// </summary>
        /// <returns></returns>
        public BasePointsInfo GetBasePoints();

        /// <summary>
        /// 生成するキャラクターの性格を取得します。
        /// </summary>
        /// <returns></returns>
        public NatureStaticInfo GetNature();
    }
}