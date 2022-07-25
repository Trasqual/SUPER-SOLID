using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class KinematicRigidbodyMotor : MotorBase
{
    [SerializeField] Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    public override void Move(Vector3 velocity)
    {
        rb.MovePosition(transform.position + velocity);
    }
}
