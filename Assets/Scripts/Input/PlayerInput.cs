using UnityEngine;

public class PlayerInput : InputBase
{
    Camera cam;

    private void Awake()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnInputPressed?.Invoke();
        }
        if (Input.GetMouseButtonUp(0))
        {
            OnInputReleased?.Invoke();
        }
        if (Input.GetMouseButton(0))
        {
            OnInputHold?.Invoke(GetDirectionFromMousePosition());
        }
    }

    private Vector3 GetDirectionFromMousePosition()
    {
        var playerScreenPos = cam.WorldToScreenPoint(transform.position);
        playerScreenPos.z = 0f;
        var dir = Input.mousePosition - playerScreenPos;
        dir.z = dir.y;
        dir.y = 0f;
        dir.Normalize();
        dir = Quaternion.Euler(0f, cam.transform.rotation.y, 0f) * dir;
        return dir;
    }
}
