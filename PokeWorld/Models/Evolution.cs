using System.Collections.Generic;

namespace PokeWorld.Models
{
    /// <summary>
    /// 進化情報を格納するレコードです。
    /// </summary>
    public record Evolution(
        int Priority,
        string EvolveTo,
        string Condition,
        IEnumerable<object> ConditionArgs
        )
    {
        /// <summary>
        /// 適用される進化の優先度を取得します。数値が小さいほど優先されます。
        /// </summary>
        public int Priority { get; init; } = Priority;

        /// <summary>
        /// 進化先の種族を表す種族キーを取得します。
        /// </summary>
        public string EvolveTo { get; init; } = EvolveTo;

        /// <summary>
        /// 進化条件スクリプトの名前を取得します。
        /// </summary>
        public string Condition { get; init; } = Condition;

        /// <summary>
        /// 進化条件スクリプトに渡すパラメータのコレクションを取得します。
        /// </summary>
        public IEnumerable<object> ConditionArgs { get; init; } = ConditionArgs;
    }
}
