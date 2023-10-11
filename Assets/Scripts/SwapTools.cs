using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WorkProject
{
    public class SwapTools : MonoBehaviour
    {
        public List<GameObject> tools;
        
        private void Start()
        {
<<<<<<< HEAD
            ChangeTool();
=======
          
>>>>>>> 22883cc0f977cb5eb93d626d72328b53719d11ab
        }
        
        public void ChangeTool()
        {
            var index = Random.Range(0, tools.Count);
            SetActiveTool(index);
        }
        
        private void SetActiveTool(int index)
        {
            for(int i = 0; i < tools.Count; i++)
            {
                tools[i].SetActive(i == index);
            }   
        }



    }
}