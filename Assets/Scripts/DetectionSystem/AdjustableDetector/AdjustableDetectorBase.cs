using UnityEngine;

public abstract class AdjustableDetectorBase : DetectorBase
{
    protected Vector3 _detectorPosition;
    protected float _detectorRange = 10f;
    protected LayerMask _detectionMask;

    public void Initialize(Vector3 pos, float range, LayerMask mask)
    {
        _detectorPosition = pos;
        _detectorRange = range;
        _detectionMask = mask;
    }

    public void SetPosition(Vector3 pos)
    {
        _detectorPosition = pos;
    }

    public void SetRange(float range)
    {
        _detectorRange = range;
    }

    public void SetMask(LayerMask mask)
    {
        _detectionMask = mask;
    }
}
