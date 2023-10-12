using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cleaner
{
    public class PlayerController : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("MouseActive");
            }
        }
    }
}