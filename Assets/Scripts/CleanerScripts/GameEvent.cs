using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameEvent
{
    public static event System.Action onCollisionStone;
    public static event System.Action onStickHit;

    public static void CollisionStoneInvoke(Collision collision)
    { 
        onCollisionStone?.Invoke();
    }

    public static void StickHit()
    { 
        onStickHit?.Invoke();
    }
}
