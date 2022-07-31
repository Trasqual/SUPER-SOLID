using UnityEngine;

public static class VelocityCalculator
{
    public static Vector3 CalculateSimpleVelocity(Vector3 dir, float speed)
    {
        return speed * Time.deltaTime * dir;
    }
}
