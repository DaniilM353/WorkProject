using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    
    [SerializeField] private Player player;

    
    // private void Update()
    //{
    //   player.SetDown(Input.GetMouseButton(0));
    //}

    public void OnDown()
    {
        player.SetDown(true);
    }

    public void OnUp() 
    {
        player.SetDown(false);
    }
    
}