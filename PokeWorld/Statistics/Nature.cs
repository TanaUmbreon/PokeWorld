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
            attack: CorrectionRate.NoChange,
            defence: CorrectionRate.NoChange,
            spAttack: CorrectionRate.NoChange,
            spDefence: CorrectionRate.NoChange,
            speed: CorrectionRate.NoChange
            );

        #region 列挙型クラスのインスタンス メンバ

        /// <summary>
        /// こうげきのせいかく補正を取得します。
        /// </summary>
        public CorrectionRate Attack { get; private set; }

        /// <summary>
        /// ぼうぎょのせいかく補正を取得します。
        /// </summary>
        public CorrectionRate Defence { get; private set; }

        /// <summary>
        /// とくこうのせいかく補正を取得します。
        /// </summary>
        public CorrectionRate SpAttack { get; private set; }

        /// <summary>
        /// とくぼうのせいかく補正を取得します。
        /// </summary>
        public CorrectionRate SpDefence { get; private set; }

        /// <summary>
        /// すばやさのせいかく補正を取得します。
        /// </summary>
        public CorrectionRate Speed { get; private set; }

        /// <summary>
        /// <see cref="Nature"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="id">せいかくを一意に特定する為の識別子。</param>
        /// <param name="name">せいかく名。</param>
        /// <param name="attack">こうげきのせいかく補正。</param>
        /// <param name="defence">ぼうぎょのせいかく補正。</param>
        /// <param name="spAttack">とくこうのせいかく補正。</param>
        /// <param name="spDefence">とくぼうのせいかく補正。</param>
        /// <param name="speed">すばやさのせいかく補正。</param>
        private Nature(int id, string name, CorrectionRate attack, CorrectionRate defence, CorrectionRate spAttack, CorrectionRate spDefence, CorrectionRate speed) :
            base(id, name)
        {
            Attack = attack;
            Defence = defence;
            SpAttack = spAttack;
            SpDefence = spDefence;
            Speed = speed;
        }

        #endregion
    }
}
