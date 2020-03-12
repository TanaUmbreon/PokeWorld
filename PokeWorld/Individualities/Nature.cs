using PokeWorld.DomainSupport;

namespace PokeWorld.Individualities
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

        /// <summary>さみしがり</summary>
        public static readonly Nature Lonely = new Nature(
            id: 1,
            name: "さみしがり",
            attack: NatureCorrection.Increased,
            defense: NatureCorrection.Decreased,
            spAttack: NatureCorrection.NoChange,
            spDefense: NatureCorrection.NoChange,
            speed: NatureCorrection.NoChange
            );

        /// <summary>ゆうかん</summary>
        public static readonly Nature Brave = new Nature(
            id: 2,
            name: "ゆうかん",
            attack: NatureCorrection.Increased,
            defense: NatureCorrection.NoChange,
            spAttack: NatureCorrection.NoChange,
            spDefense: NatureCorrection.NoChange,
            speed: NatureCorrection.Decreased
            );

        /// <summary>いじっぱり</summary>
        public static readonly Nature Adamant = new Nature(
            id: 3,
            name: "いじっぱり",
            attack: NatureCorrection.Increased,
            defense: NatureCorrection.NoChange,
            spAttack: NatureCorrection.Decreased,
            spDefense: NatureCorrection.NoChange,
            speed: NatureCorrection.NoChange
            );

        /// <summary>やんちゃ</summary>
        public static readonly Nature Naughty = new Nature(
            id: 4,
            name: "やんちゃ",
            attack: NatureCorrection.Increased,
            defense: NatureCorrection.NoChange,
            spAttack: NatureCorrection.NoChange,
            spDefense: NatureCorrection.Decreased,
            speed: NatureCorrection.NoChange
            );

        /// <summary>ずぶとい</summary>
        public static readonly Nature Bold = new Nature(
            id: 5,
            name: "ずぶとい",
            attack: NatureCorrection.Decreased,
            defense: NatureCorrection.Increased,
            spAttack: NatureCorrection.NoChange,
            spDefense: NatureCorrection.NoChange,
            speed: NatureCorrection.NoChange
            );

        /// <summary>すなお</summary>
        public static readonly Nature Docile = new Nature(
            id: 6,
            name: "すなお",
            attack: NatureCorrection.NoChange,
            defense: NatureCorrection.NoChange,
            spAttack: NatureCorrection.NoChange,
            spDefense: NatureCorrection.NoChange,
            speed: NatureCorrection.NoChange
            );

        /// <summary>のんき</summary>
        public static readonly Nature Relaxed = new Nature(
            id: 7,
            name: "のんき",
            attack: NatureCorrection.NoChange,
            defense: NatureCorrection.Increased,
            spAttack: NatureCorrection.NoChange,
            spDefense: NatureCorrection.NoChange,
            speed: NatureCorrection.Decreased
            );

        /// <summary>わんぱく</summary>
        public static readonly Nature Impish = new Nature(
            id: 8,
            name: "わんぱく",
            attack: NatureCorrection.NoChange,
            defense: NatureCorrection.Increased,
            spAttack: NatureCorrection.Decreased,
            spDefense: NatureCorrection.NoChange,
            speed: NatureCorrection.NoChange
            );

        /// <summary>のうてんき</summary>
        public static readonly Nature Lax = new Nature(
            id: 9,
            name: "のうてんき",
            attack: NatureCorrection.NoChange,
            defense: NatureCorrection.Increased,
            spAttack: NatureCorrection.NoChange,
            spDefense: NatureCorrection.Decreased,
            speed: NatureCorrection.NoChange
            );

        /// <summary>おくびょう</summary>
        public static readonly Nature Timid = new Nature(
            id: 10,
            name: "おくびょう",
            attack: NatureCorrection.Decreased,
            defense: NatureCorrection.NoChange,
            spAttack: NatureCorrection.NoChange,
            spDefense: NatureCorrection.NoChange,
            speed: NatureCorrection.Increased
            );

        /// <summary>せっかち</summary>
        public static readonly Nature Hasty = new Nature(
            id: 11,
            name: "せっかち",
            attack: NatureCorrection.NoChange,
            defense: NatureCorrection.Decreased,
            spAttack: NatureCorrection.NoChange,
            spDefense: NatureCorrection.NoChange,
            speed: NatureCorrection.Increased
            );

        /// <summary>まじめ</summary>
        public static readonly Nature Serious = new Nature(
            id: 12,
            name: "まじめ",
            attack: NatureCorrection.NoChange,
            defense: NatureCorrection.NoChange,
            spAttack: NatureCorrection.NoChange,
            spDefense: NatureCorrection.NoChange,
            speed: NatureCorrection.NoChange
            );

        /// <summary>ようき</summary>
        public static readonly Nature Jolly = new Nature(
            id: 13,
            name: "ようき",
            attack: NatureCorrection.NoChange,
            defense: NatureCorrection.NoChange,
            spAttack: NatureCorrection.Decreased,
            spDefense: NatureCorrection.NoChange,
            speed: NatureCorrection.Increased
            );

        /// <summary>むじゃき</summary>
        public static readonly Nature Naive = new Nature(
            id: 14,
            name: "むじゃき",
            attack: NatureCorrection.NoChange,
            defense: NatureCorrection.NoChange,
            spAttack: NatureCorrection.NoChange,
            spDefense: NatureCorrection.Decreased,
            speed: NatureCorrection.Increased
            );

        /// <summary>ひかえめ</summary>
        public static readonly Nature Modest = new Nature(
            id: 15,
            name: "ひかえめ",
            attack: NatureCorrection.Decreased,
            defense: NatureCorrection.NoChange,
            spAttack: NatureCorrection.Increased,
            spDefense: NatureCorrection.NoChange,
            speed: NatureCorrection.NoChange
            );

        /// <summary>おっとり</summary>
        public static readonly Nature Mild = new Nature(
            id: 16,
            name: "おっとり",
            attack: NatureCorrection.NoChange,
            defense: NatureCorrection.Decreased,
            spAttack: NatureCorrection.Increased,
            spDefense: NatureCorrection.NoChange,
            speed: NatureCorrection.NoChange
            );

        /// <summary>れいせい</summary>
        public static readonly Nature Quiet = new Nature(
            id: 17,
            name: "れいせい",
            attack: NatureCorrection.NoChange,
            defense: NatureCorrection.NoChange,
            spAttack: NatureCorrection.Increased,
            spDefense: NatureCorrection.NoChange,
            speed: NatureCorrection.Decreased
            );

        /// <summary>てれや</summary>
        public static readonly Nature Bashful = new Nature(
            id: 18,
            name: "てれや",
            attack: NatureCorrection.NoChange,
            defense: NatureCorrection.NoChange,
            spAttack: NatureCorrection.NoChange,
            spDefense: NatureCorrection.NoChange,
            speed: NatureCorrection.NoChange
            );

        /// <summary>うっかりや</summary>
        public static readonly Nature Rash = new Nature(
            id: 19,
            name: "うっかりや",
            attack: NatureCorrection.NoChange,
            defense: NatureCorrection.NoChange,
            spAttack: NatureCorrection.Increased,
            spDefense: NatureCorrection.Decreased,
            speed: NatureCorrection.NoChange
            );

        /// <summary>おだやか</summary>
        public static readonly Nature Calm = new Nature(
            id: 20,
            name: "おだやか",
            attack: NatureCorrection.Decreased,
            defense: NatureCorrection.NoChange,
            spAttack: NatureCorrection.NoChange,
            spDefense: NatureCorrection.Increased,
            speed: NatureCorrection.NoChange
            );

        /// <summary>おとなしい</summary>
        public static readonly Nature Gentle = new Nature(
            id: 21,
            name: "おとなしい",
            attack: NatureCorrection.NoChange,
            defense: NatureCorrection.Decreased,
            spAttack: NatureCorrection.NoChange,
            spDefense: NatureCorrection.Increased,
            speed: NatureCorrection.NoChange
            );

        /// <summary>なまいき</summary>
        public static readonly Nature Sassy = new Nature(
            id: 22,
            name: "なまいき",
            attack: NatureCorrection.NoChange,
            defense: NatureCorrection.NoChange,
            spAttack: NatureCorrection.NoChange,
            spDefense: NatureCorrection.Increased,
            speed: NatureCorrection.Decreased
            );

        /// <summary>しんちょう</summary>
        public static readonly Nature Careful = new Nature(
            id: 23,
            name: "しんちょう",
            attack: NatureCorrection.NoChange,
            defense: NatureCorrection.NoChange,
            spAttack: NatureCorrection.Decreased,
            spDefense: NatureCorrection.Increased,
            speed: NatureCorrection.NoChange
            );

        /// <summary>きまぐれ</summary>
        public static readonly Nature Quirky = new Nature(
            id: 24,
            name: "きまぐれ",
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
