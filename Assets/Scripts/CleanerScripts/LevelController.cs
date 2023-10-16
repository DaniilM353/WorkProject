using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//namespace WorkProject
//{
    public class LevelController : MonoBehaviour
    {
        public Spawner spawner;
        public bool isGameOver = false;

        public float delayMax = 2f;
        public float delayMin = 0.5f;
        public float delayStep = 0.05f;

        public int score = 0;
        public int hightScore = 0;

        private float m_delay = 0.5f;

        private List<GameObject> m_stones = new List<GameObject>(16);

        public void ClearStone()
        {
            foreach (var stone in m_stones)
            {
                Destroy(stone);
            }

            m_stones.Clear();
        }

        
        private void Start()
        {
            StartCoroutine(SpawnStoneProc());
            RefreshDelay();
        }

        private void OnEnable()
        {
            GameEvent.onStickHit += OnStickHit;

        }

        private void OnDisable()
        {
            GameEvent.onStickHit -= OnStickHit;
        }

        private void OnStickHit()
        {
            score++;
            hightScore = Math.Max(hightScore, score);
        }


        private IEnumerator SpawnStoneProc()
        {
            do
            {
                yield return new WaitForSeconds(m_delay);
                
                var stone = spawner.Spawn();
                m_stones.Add(stone);
                
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
//}