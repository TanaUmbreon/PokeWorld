using PokeWorld.Common;
using PokeWorld.Models;

namespace PokeWorld.Repositories
{
    /// <summary>
    /// 静的データへの物理的な操作を隠蔽し、抽象度の高い操作を提供します。
    /// </summary>
    public interface IStaticRepository
    {
        /// <summary>
        /// 種族情報の静的データ コレクションを取得します。
        /// </summary>
        KeyRecordCollection<Species> Species { get; }
    }
}
