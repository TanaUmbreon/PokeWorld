using System;
using System.Collections.Generic;
using System.Linq;
using PokeWorld.Models.Static;

namespace PokeWorld.Models
{
    /// <summary>
    /// ポケモン バトル用のキャラクターを表します。
    /// </summary>
    public class BattleCharacter
    {
        /// <summary>
        /// 種族の静的データを取得します。
        /// </summary>
        public SpeciesStaticInfo Species { get; private set; }

        /// <summary>
        /// レベルを取得します。
        /// </summary>
        public int Level { get; private set; }

        /// <summary>
        /// ステータス (実数値) を取得します。
        /// </summary>
        public StatInfo Stat { get; private set; }

        /// <summary>
        /// 生まれつきのつよさ (個体値) を取得します。
        /// </summary>
        public IndividualStrengthsInfo IndividualStrengths { get; private set; }

        /// <summary>
        /// 基礎ポイント (努力値) を取得します。
        /// </summary>
        public BasePointsInfo BasePoints { get; private set; }

        /// <summary>
        /// 性格を取得します。
        /// </summary>
        public NatureStaticInfo Nature { get; private set; }

        /// <summary>
        /// 指定したアルゴリズムを使用して <see cref="BattleCharacter"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="generator">キャラクターの生成に使用するアルゴリズム。</param>
        public BattleCharacter(IBattleCharacterGenerator generator)
        {
            Species = generator.GetSpecies();
            Level = generator.GetLevel();
            Stat = generator.GetStat();
            IndividualStrengths = generator.GetIndividualStrengths();
            BasePoints = generator.GetBasePoints();
            Nature = generator.GetNature();
        }

    }
}
