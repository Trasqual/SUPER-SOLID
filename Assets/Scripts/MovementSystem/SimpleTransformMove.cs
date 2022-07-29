using UnityEngine;

public class SimpleTransformMove : MovementBase
{
    public override void Move(Vector3 velocity)
    {
        transform.position += velocity;
    }
}
