using UnityEngine;

public abstract class ProjectileControllerBase : MonoBehaviour
{
    protected MovementBase _mover;
    protected DirectionProviderBase _directionProvider;
    protected VelocityCalculator _velocityCalculator;

    private void Awake()
    {
        _mover = GetComponent<MovementBase>();
        _directionProvider = GetComponent<DirectionProviderBase>();
        _velocityCalculator = GetComponent<VelocityCalculator>();
    }

    protected abstract void ProcessMovement();
}
