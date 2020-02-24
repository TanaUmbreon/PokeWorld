using System;
using System.Collections.Generic;
using System.Text;

namespace PokeWorld.Statistics
{
    /// <summary>
    /// ポケモンを表します。
    /// </summary>
    public class Pokemon
    {
        /// <summary>種族</summary>
        private readonly Species species;
        /// <summary>レベル & 経験値操作オブジェクト</summary>
        private readonly LevelExperienceControler levelControler;

        /// <summary>
        /// レベルを取得します。
        /// </summary>
        public Level Level => levelControler.Level;

        /// <summary>
        /// 累計経験値を取得します。
        /// </summary>
        public Experience TotalExp => levelControler.TotalExp;

        /// <summary>
        /// 次のレベルまでの必要経験値を取得します。
        /// </summary>
        public Experience RequiredExpToNextLevel => levelControler.RequiredExpToNextLevel;

        /// <summary>
        /// <see cref="Pokemon"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="species">種族。</param>
        /// <param name="level">レベル。</param>
        public Pokemon(Species species, Level level)
        {
            this.species = species;
            levelControler = new LevelExperienceControler(species.ExpType, level);
        }
    }
}
