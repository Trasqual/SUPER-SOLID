using UnityEngine;

public class SphericalClosestTargetDetector : AdjustableDetectorBase
{
    
    public override Transform GetTarget()
    {
        return FindClosestTarget();
    }

    private Transform FindClosestTarget()
    {
        var targets = Physics.OverlapSphere(transform.position, _detectionRange, _detectionMask);

        return ClosestFinder.FindClosestTransform(_detectorPosition, targets);
    }
}
