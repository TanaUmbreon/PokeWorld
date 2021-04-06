using System;
using System.Collections.Generic;
using System.Linq;

namespace PokeWorld.Models
{
    /// <summary>
    /// ステータス (実数値) を表します。
    /// </summary>
    public class StatInfo
    {
        /// <summary>
        /// HP を取得します。
        /// </summary>
        public int HitPoints { get; private set; }

        /// <summary>
        /// こうげきを取得します。
        /// </summary>
        public int Attack { get; private set; }

        /// <summary>
        /// ぼうぎょを取得します。
        /// </summary>
        public int Defense { get; private set; }

        /// <summary>
        /// とくこうを取得します。
        /// </summary>
        public int SpecialAttack { get; private set; }

        /// <summary>
        /// とくぼうを取得します。
        /// </summary>
        public int SpecialDefense { get; private set; }

        /// <summary>
        /// すばやさを取得します。
        /// </summary>
        public int Speed { get; private set; }

        /// <summary>
        /// <see cref="StatInfo"/> の新しいインスタンスを生成します。
        /// </summary>
        public StatInfo() { }
    }
}
