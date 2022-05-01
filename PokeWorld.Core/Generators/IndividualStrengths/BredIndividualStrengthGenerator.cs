/*
using PokeWorld.Core.Helpers;
using PokeWorld.Core.Models;

namespace PokeWorld.Core.Generators.IndividualStrengths
{
    /// <summary>
    /// 両親から遺伝された個体値のセットを生成する機能を提供します。
    /// </summary>
    public class BredIndividualStrengthGenerator : IIndividualStrengthSetGenerator
    {
        /// <summary>既定で遺伝する個体値の数</summary>
        private const int DefaultPassingDownCount = 3;
        /// <summary>あかいいとで遺伝する個体値の数</summary>
        private const int DestinyKnotPassingDownCount = 5;

        /// <summary>使用する乱数ジェネレーター</summary>
        private readonly IRandomizer _randomizer;

        /// <summary>預けた♂ポケモンまたはメタモンの個体値のセット</summary>
        private readonly IndividualStrengthSet _male;
        /// <summary>預けた♀ポケモンまたはメタモンの個体値のセット</summary>
        private readonly IndividualStrengthSet _female;
        /// <summary>両親から遺伝する個体値の数</summary>
        private readonly int _passingDownCount;
        /// <summary>持たせているパワー系アイテム</summary>
        private readonly IList<StatDetail> _holdingPowerItems;

        /// <summary>
        /// <see cref="BredIndividualStrengthGenerator"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="male"></param>
        /// <param name="female"></param>
        /// <param name="randomizer"></param>
        public BredIndividualStrengthGenerator(Pokemon male, Pokemon female, IRandomizer randomizer)
        {
            _randomizer = randomizer;

            // ToDo: 両親の個体値を参照するように実装する。
            _male = new IndividualStrengthSet(0, 0, 0, 0, 0, 0);
            _female = new IndividualStrengthSet(0, 0, 0, 0, 0, 0);

            bool holdsDestinyKnot = false; // ToDo: あかいいとを持っている場合はtrueとなるように実装する。
            _passingDownCount = holdsDestinyKnot ? DestinyKnotPassingDownCount : DefaultPassingDownCount;

            _holdingPowerItems = Array.Empty<StatDetail>(); // ToDo: 両親がそれぞれ持っているパワー系アイテムを追加するように実装する。
        }

        public IndividualStrengthSet Generate()
        {
            var passingDownStats = new List<StatDetail>(); // 遺伝するステータス
            var passingDownCandidacies = new List<StatDetail>() // 遺伝候補のステータス
            {
                StatDetail.HitPoint,
                StatDetail.Attack,
                StatDetail.Defense,
                StatDetail.SpecialAttack,
                StatDetail.SpecialDefense,
                StatDetail.Speed,
            };
            int passingDownCount = _passingDownCount;

            // 両親がパワー系アイテムを持っている場合は該当するステータスを確定で遺伝する
            // 複数 (両親とも) 持っている場合はどれか1つだけ選ばれる
            if (_holdingPowerItems.Any())
            {
                StatDetail passingDownStat = _randomizer.SelectOne(_holdingPowerItems);

                passingDownStats.Add(passingDownStat);
                passingDownCandidacies.Remove(passingDownStat);
                passingDownCount--;
            }

            // 残りの遺伝するステータスを選ぶ
            while (passingDownCount > 0 || passingDownCandidacies.Count <= 0)
            {
                StatDetail passingDownStat = _randomizer.SelectOne(passingDownCandidacies);

                passingDownStats.Add(passingDownStat);
                passingDownCandidacies.Remove(passingDownStat);
                passingDownCount--;
            }

            // ToDo: 遺伝するステータスとして選ばれている場合は両親のいずれから、そうでない場合はランダムとなるように実装する。
            int hp = passingDownStats.Contains(StatDetail.HitPoint)
                ? _randomizer.Next(2) == 0 ? _male.HitPoint.OriginalValue : _female.HitPoint.OriginalValue
                : _randomizer.Next(IndividualStrength.Range);
            return new(hp, 0, 0, 0, 0, 0);
        }
    }
}
*/