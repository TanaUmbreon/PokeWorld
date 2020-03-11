using System;
using System.Collections.Generic;
using System.Text;
using PokeWorld.DomainSupport;

namespace PokeWorld.Statistics
{
    /// <summary>
    /// せいかくを表します。
    /// </summary>
    public sealed class Nature : Enumeration
    {
        /// <summary>がんばりや</summary>
        public static readonly Nature Hardy = new Nature(
            id: 0,
            name: "がんばりや",
            attack: NatureCorrection.NoChange,
            defense: NatureCorrection.NoChange,
            spAttack: NatureCorrection.NoChange,
            spDefense: NatureCorrection.NoChange,
            speed: NatureCorrection.NoChange
            );

        #region 列挙型クラスのインスタンス メンバ

        /// <summary>
        /// こうげきのせいかく補正を取得します。
        /// </summary>
        public NatureCorrection Attack { get; private set; }

        /// <summary>
        /// ぼうぎょのせいかく補正を取得します。
        /// </summary>
        public NatureCorrection Defense { get; private set; }

        /// <summary>
        /// とくこうのせいかく補正を取得します。
        /// </summary>
        public NatureCorrection SpAttack { get; private set; }

        /// <summary>
        /// とくぼうのせいかく補正を取得します。
        /// </summary>
        public NatureCorrection SpDefense { get; private set; }

        /// <summary>
        /// すばやさのせいかく補正を取得します。
        /// </summary>
        public NatureCorrection Speed { get; private set; }

        /// <summary>
        /// <see cref="Nature"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="id">せいかくを一意に特定する為の識別子。</param>
        /// <param name="name">せいかく名。</param>
        /// <param name="attack">こうげきのせいかく補正。</param>
        /// <param name="defense">ぼうぎょのせいかく補正。</param>
        /// <param name="spAttack">とくこうのせいかく補正。</param>
        /// <param name="spDefense">とくぼうのせいかく補正。</param>
        /// <param name="speed">すばやさのせいかく補正。</param>
        private Nature(int id, string name, NatureCorrection attack, NatureCorrection defense, NatureCorrection spAttack, NatureCorrection spDefense, NatureCorrection speed) :
            base(id, name)
        {
            Attack = attack;
            Defense = defense;
            SpAttack = spAttack;
            SpDefense = spDefense;
            Speed = speed;
        }

        #endregion
    }
}
