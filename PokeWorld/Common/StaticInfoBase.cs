namespace PokeWorld.Common
{
    /// <summary>
    /// 静的データを格納する基底クラスです。このクラスは不変です。
    /// </summary>
    public abstract record StaticInfoBase(string Key)
    {
        /// <summary>
        /// インスタンスを一意に特定する文字列型識別子を取得します。
        /// </summary>
        public string Key { get; init; } = Key;
    }
}
