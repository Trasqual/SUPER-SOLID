using UnityEngine;

[CreateAssetMenu(menuName = "AnimationCurveScriptable")]
public class AnimationCurveScriptable : ScriptableObject
{
    [SerializeField] AnimationCurve xCurve;
    [SerializeField] AnimationCurve yCurve;
    [SerializeField] AnimationCurve zCurve;

    public AnimationCurve XCurve => xCurve;
    public AnimationCurve YCurve => yCurve;
    public AnimationCurve ZCurve => zCurve;
}
