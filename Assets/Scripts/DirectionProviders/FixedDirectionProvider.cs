using UnityEngine;

public class FixedDirectionProvider : DirectionProviderBase
{
    [Header("Debug")]
    [SerializeField] Vector3 _fixedDir;

    public void SetDirection(Vector3 dir)
    {
        _fixedDir = dir;
    }

    protected override void CalculateDirection()
    {
        _direction = _fixedDir;
    }

    private void Update()
    {
        CalculateDirection();
    }
}
