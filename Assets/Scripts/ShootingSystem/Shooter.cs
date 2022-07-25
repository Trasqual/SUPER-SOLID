
using UnityEngine;

public class SimpleShooter : ShooterBase
{
    [SerializeField] protected GameObject prefab;

    public override void Shoot()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
