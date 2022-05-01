using PokeWorld.Core.Helpers;

namespace PokeWorld.Core.Models;

/// <summary>
/// 生まれつきの強さ (個体値) を表します。このオブジェクトは不変です。
/// </summary>
/// <param name="OriginalValue">すごいとっくんにより鍛える前の本来の生まれつきの強さ。有効範囲外の値を指定した場合は範囲に収まるようにクランプします。</param>
/// <param name="HasTrainedHyper">すごいとっくんにより鍛えた事を示す値。</param>
public record IndividualStrength(int OriginalValue, bool HasTrainedHyper = false)
{
    /// <summary>
    /// 生まれつきの強さの有効範囲を取得します。
    /// </summary>
    public static ValueRange Range { get; } = new(min: 0, max: 31);

    /// <summary>
    /// すごいとっくんにより鍛える前の、本来の生まれつきの強さを取得します。
    /// </summary>
    public int OriginalValue { get; init; } = Range.Clamp(OriginalValue);

    /// <summary>
    /// すごいとっくんにより鍛えた事を示す値を取得します。
    /// </summary>
    public bool HasTrainedHyper { get; init; } = HasTrainedHyper;

    /// <summary>
    /// 本来の生まれつきの強さが最大値である事を示す値を取得します。
    /// </summary>
    public bool IsMax()
        => OriginalValue == Range.Max;

    /// <summary>
    /// すごいとっくんによる効果を適用した上での、実際の生まれつきの強さを取得します。
    /// </summary>
    /// <returns></returns>
    public int GetActualValue()
        => HasTrainedHyper ? Range.Max : OriginalValue;

    /// <summary>
    /// ジャッジによる判定を取得します。この値は、すごいとっくんによる効果を無視した本来の生まれつきの強さを元に返します。
    /// </summary>
    /// <returns></returns>
    public IndividualStrengthJudge GetJudge()
        => (IndividualStrengthJudge)OriginalValue switch
        {
            <= IndividualStrengthJudge.NoGood => IndividualStrengthJudge.NoGood,
            <= IndividualStrengthJudge.Decent => IndividualStrengthJudge.Decent,
            <= IndividualStrengthJudge.PrettyGood => IndividualStrengthJudge.PrettyGood,
            <= IndividualStrengthJudge.VeryGood => IndividualStrengthJudge.VeryGood,
            <= IndividualStrengthJudge.Fantastic => IndividualStrengthJudge.Fantastic,
            _ => IndividualStrengthJudge.Best
        };

    /// <summary>
    /// すごいとっくんで鍛え、その結果を新しいインスタンスで返します。
    /// </summary>
    /// <returns><see cref="HasTrainedHyper">HasTrainedHyper</see> が true になった新しい <see cref="IndividualStrength"/> のインスタンス。</returns>
    public IndividualStrength TrainHyper()
    {
        return new(this) { HasTrainedHyper = true };
    }
}
