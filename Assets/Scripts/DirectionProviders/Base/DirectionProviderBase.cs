using UnityEngine;

public abstract class DirectionProviderBase : MonoBehaviour
{
    protected Vector3 _direction;

    public virtual Vector3 GetDirection() => _direction;

    protected abstract void CalculateDirection();
}
