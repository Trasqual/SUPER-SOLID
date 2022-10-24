using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardsDirection : RotationBase
{
    public override void Rotate(Vector3 dir)
    {
        transform.rotation = Quaternion.LookRotation(dir);
    }
}
