using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WorkProject
{
    public class LevelController : MonoBehaviour
    {
        public Spawner spawner;
        public bool isGameOver = false;

        public float delayMax = 2f;
        public float delayMin = 0.5f;
        public float delayStep = 0.05f;

        private float m_delay = 0.5f;
        
        private void Start()
        {
            StartCoroutine(SpawnStoneProc());
            RefreshDelay();
        }

        private void OnEnable()
        {
            Stone.onCollisionStone += GameOver;
        }

        private void OnDisable()
        {
            Stone.onCollisionStone -= GameOver;
        }

        private void GameOver()
        {
            Debug.Log("Game Over");
            isGameOver = true;
        }

        private IEnumerator SpawnStoneProc()
        {
            do
            {
                yield return new WaitForSeconds(m_delay);
                
                spawner.Spawn();
                
                RefreshDelay();
            }
            while (!isGameOver);
        }

        public void RefreshDelay()
        {
            m_delay = UnityEngine.Random.Range(delayMin, delayMax);
            delayMax = Math.Max(delayMin, delayMax - delayStep);
        }
    }
}