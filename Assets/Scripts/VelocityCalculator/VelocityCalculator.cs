using UnityEngine;

public class VelocityCalculator : MonoBehaviour
{
    public Vector3 CalculatedVelocity(Vector3 dir, float speed)
    {
        return speed * Time.deltaTime * dir;
    }
}
