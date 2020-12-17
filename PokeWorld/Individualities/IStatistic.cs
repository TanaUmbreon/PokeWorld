namespace PokeWorld.Individualities
{
    /// <summary>
    /// 能力値を実装します。
    /// </summary>
    public interface IStatistic { }

    /// <summary>
    /// HP を表します。
    /// </summary>
    public class HitPoints : IStatistic { }

    /// <summary>
    /// こうげきを表します。
    /// </summary>
    public class Attack : IStatistic { }

    /// <summary>
    /// ぼうぎょを表します。
    /// </summary>
    public class Defense : IStatistic { }

    /// <summary>
    /// とくこうを表します。
    /// </summary>
    public class SpecialAttack : IStatistic { }

    /// <summary>
    /// とくぼうを表します。
    /// </summary>
    public class SpecialDefense : IStatistic { }

    /// <summary>
    /// すばやさを表します。
    /// </summary>
    public class Speed : IStatistic { }
}
