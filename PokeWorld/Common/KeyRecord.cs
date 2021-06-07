namespace PokeWorld.Common
{
    /// <summary>
    /// インスタンスを一意に特定するためのキー名を持つ基底レコードです。このクラスは不変です。
    /// </summary>
    public abstract record KeyRecord(string Key)
    {
        /// <summary>
        /// インスタンスを一意に特定する文字列型識別子を取得します。
        /// </summary>
        public string Key { get; init; } = Key;
    }
}
