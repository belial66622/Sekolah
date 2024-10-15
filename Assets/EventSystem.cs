using System;
using UnityEngine;

public static class EventSystem 
{
    public static Action<Vector3> MovementEvent;

    public static void Movement(Vector3 dir)
    { 
        MovementEvent?.Invoke(dir);
    }
}
