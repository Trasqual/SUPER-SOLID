
public class SimpleProjectile : ProjectileControllerBase
{
    protected override void ProcessMovement()
    {
        _mover.Move(VelocityCalculator.CalculateSimpleVelocity(_directionProvider.GetDirection(), 5f));
    }

    private void Update()
    {
        ProcessMovement();
    }
}
