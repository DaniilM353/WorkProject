using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    public bool isAfect = false;
    public static System.Action onCollisionStone;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.TryGetComponent(out Stone other))
        {
            if (!other.isAfect)
            {
                onCollisionStone?.Invoke();
            }
        }
    }
}
