using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MainMenuState : MonoBehaviour
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
