using UnityEngine;

public abstract class TargetedInput : InputBase
{
    public abstract Vector3 Direction(Vector3 target, float time);
}
