using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    
    [SerializeField] private Player player;

    
    private void Update()
    {
        player.SetDown(Input.GetMouseButton(0));
    }
    
}