using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverState : MonoBehaviour
{
    public List<GameObject> views;

    private void OnEnable()
    {
        foreach (var item in views)
        {
            item.SetActive(true);
        }
    }

    private void OnDisable()
    {
        foreach (var item in views)
        {
            item.SetActive(false);
        }
    }
}
