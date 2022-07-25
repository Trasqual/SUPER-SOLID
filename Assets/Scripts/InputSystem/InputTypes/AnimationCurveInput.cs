
using UnityEngine;

public class AnimationCurveInput : TargetedInput
{
    [SerializeField] AnimationCurveScriptable curve;

    public override Vector3 Direction(Vector3 target, float time)
    {
        var distance = Vector3.Distance(transform.position, target);

        return transform.forward + distance * new Vector3(curve.XCurve.Evaluate(time), curve.YCurve.Evaluate(time), curve.ZCurve.Evaluate(time));
    }
}
