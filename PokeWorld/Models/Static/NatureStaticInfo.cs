using System.Diagnostics;

namespace PokeWorld.Models.Static
{
    /// <summary>
    /// せいかくの静的データを格納します。
    /// </summary>
    [DebuggerDisplay(@"\{ Id = {Id}, Key = {Key} \}")]
    public record NatureStaticInfo(
        int Id,
        string Key,
        NatureCorrections Corrections)
        : StaticInfo(Id, Key)
    {
        /// <summary>
        /// 性格補正のセットを取得します。
        /// </summary>
        public NatureCorrections Corrections { get; init; } = Corrections;
    }
}
