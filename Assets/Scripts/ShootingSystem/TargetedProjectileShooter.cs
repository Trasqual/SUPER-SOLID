using UnityEngine;

public class TargetedProjectileShooter : ShooterBase
{
    [SerializeField] private TargetedProjectileBase projectilePrefab;

    public override void Shoot()
    {
        var projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
    }
}
