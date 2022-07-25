using UnityEngine;

public abstract class TargetedProjectileBase : ProjectileBase
{
    [SerializeField] float _speed = 10f;
    [SerializeField] Transform _target;

    TargetedInput _input;
    VelocityBase _velocity;
    MotorBase _motorBase;

    float t;

    private void Update()
    {
        t += Time.deltaTime * _speed;
        _motorBase.Move(_velocity.CalculatedVelocity(_input.Direction(_target.position, t), _speed));
    }
}
