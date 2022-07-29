
public class SimpleProjectile : ProjectileControllerBase
{
    protected override void ProcessMovement()
    {
        _mover.Move(_velocityCalculator.CalculatedVelocity(_directionProvider.GetDirection(), 5f));
    }

    private void Update()
    {
        ProcessMovement();
    }
}
