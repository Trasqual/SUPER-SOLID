using System;
using UnityEngine;

public abstract class InputBase : MonoBehaviour
{
    public Action OnInputStarted;
    public Action OnInputEnded;
    public Action<Vector2> OnInputHold;
}
