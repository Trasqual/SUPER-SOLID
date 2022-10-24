using UnityEngine;

public abstract class ProjectileControllerBase : MonoBehaviour
{
    protected MovementBase _mover;
    protected RotationBase _rotator;
    protected DirectionProviderBase _directionProvider;

    private void Awake()
    {
        _mover = GetComponent<MovementBase>();
        _rotator = GetComponent<RotationBase>();
        _directionProvider = GetComponent<DirectionProviderBase>();
    }

    protected abstract void ProcessMovement();
}
