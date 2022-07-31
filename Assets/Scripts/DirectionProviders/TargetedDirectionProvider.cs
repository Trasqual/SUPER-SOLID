using UnityEngine;

public class TargetedDirectionProvider : DirectionProviderBase
{
    [Header("Debug")]
    [SerializeField] Vector3 _target = Vector3.zero;

    public void SetTarget(Vector3 target)
    {
        _target = target;
    }

    protected override void CalculateDirection()
    {
        _direction = (_target - transform.position).normalized;
    }

    public override Vector3 GetDirection()
    {
        if (Vector3.Distance(_target, transform.position) > 0.1f)
        {
            CalculateDirection();
        }
        else
        {
            transform.position = _target;
            _direction = Vector3.zero;
        }

        return _direction;
    }
}
