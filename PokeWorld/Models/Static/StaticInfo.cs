namespace PokeWorld.Models.Static
{
    /// <summary>
    /// 静的データを格納する為の基底レコードです。
    /// </summary>
    public abstract record StaticInfo(
        int Id,
        string Key)
    {
        /// <summary>
        /// インスタンスを一意に特定する整数値を取得します。
        /// </summary>
        public int Id { get; init; } = Id;

        /// <summary>
        /// インスタンスを一意に特定する文字列を取得します。
        /// </summary>
        public string Key { get; init; } = Key;
    }
}
