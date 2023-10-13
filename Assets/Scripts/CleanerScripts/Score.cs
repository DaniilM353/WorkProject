using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score;
    //public GameObject[] objects;

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 100), "Score: " + score );
    }

    private void OnCollisionEnter(Collision collision)
    {
	    score++;
	    Debug.Log("Toch");
    }
}
