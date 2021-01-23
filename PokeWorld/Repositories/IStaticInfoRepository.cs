using PokeWorld.Models.Static;

namespace PokeWorld.Repositories
{
    /// <summary>
    /// 静的データの直接的な操作を隠蔽し、抽象度の高いアプリケーション寄りな操作を提供します。
    /// </summary>
    public interface IStaticInfoRepository
    {
        /// <summary>
        /// せいかくの静的データ コレクションを取得します。
        /// </summary>
        StaticInfoCollection<NatureStaticInfo> Natures { get; }
    }
}
