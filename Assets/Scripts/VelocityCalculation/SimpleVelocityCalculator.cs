using UnityEngine;

public class SimpleVelocityCalculator : VelocityBase
{
    public override Vector3 CalculatedVelocity(Vector3 direction, float speed)
    {
        return speed * Time.deltaTime * direction;
    }
}
