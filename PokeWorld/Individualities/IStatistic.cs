using System;
using System.Collections.Generic;
using System.Text;

namespace PokeWorld.Individualities
{
    public interface IStatistic { }

    public class HitPoints : IStatistic { }

    public class Attack : IStatistic { }

    public class Defense : IStatistic { }

    public class SpecialAttack : IStatistic { }

    public class SpecialDefense : IStatistic { }

    public class Speed : IStatistic { }
}
