namespace PokeWorld.Core.Models;

/// <summary>
/// ジャッジによる生まれつきの強さの判定を表します。
/// </summary>
public enum IndividualStrengthJudge
{
    /// <summary>ダメかも (生まれつきの強さ: 0)</summary>
    NoGood = 0,
    /// <summary>まあまあ (生まれつきの強さ: 1～15)</summary>
    Decent = 15,
    /// <summary>かなりいい (生まれつきの強さ: 16～25)</summary>
    PrettyGood = 25,
    /// <summary>すごくいい (生まれつきの強さ: 26～29)</summary>
    VeryGood = 29,
    /// <summary>すばらしい (生まれつきの強さ: 30)</summary>
    Fantastic = 30,
    /// <summary>さいこう (生まれつきの強さ: 31)</summary>
    Best = 31,
}
