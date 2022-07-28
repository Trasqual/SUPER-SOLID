using System;
using UnityEngine;

public abstract class InputBase : MonoBehaviour
{
    public Action OnInputPressed;
    public Action OnInputReleased;
    public Action<Vector3> OnInputHold;
}
