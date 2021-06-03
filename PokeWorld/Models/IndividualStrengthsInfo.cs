﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWorld.Models
{
    /// <summary>
    /// 生まれつきのつよさ (個体値) を表します。
    /// </summary>
    public class IndividualStrengthsInfo
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
        /// <see cref="IndividualStrengthsInfo"/> の新しいインスタンスを生成します。
        /// </summary>
        public IndividualStrengthsInfo() { }
    }
}