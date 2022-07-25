using UnityEngine;

public abstract class VelocityBase : MonoBehaviour
{
    public abstract Vector3 CalculatedVelocity(Vector3 direction, float speed);
}
