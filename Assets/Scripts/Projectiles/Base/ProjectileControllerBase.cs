using UnityEngine;

public abstract class ProjectileControllerBase : MonoBehaviour
{
    protected MovementBase _mover;
    protected DirectionProviderBase _directionProvider;

    private void Awake()
    {
        _mover = GetComponent<MovementBase>();
        _directionProvider = GetComponent<DirectionProviderBase>();
    }

    protected abstract void ProcessMovement();
}
