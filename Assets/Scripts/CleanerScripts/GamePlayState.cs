using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class GamePlayState : GameState
{
    public LevelController levelController;
    public PlayerController playerController;
    public GameState gameOverState;
    public TMP_Text scoreText;

    protected override void OnEnable()
    { 
        base.OnEnable();

        levelController.enabled = true;
        playerController.enabled = true;
        playerAnimator.enabled = true;

        GameEvent.onCollisionStone += OnGameOver;
        GameEvent.onStickHit += OnStickHit;
    }

    private void OnStickHit()
    { 
        scoreText.text = $"score : {levelController.score}"; 
    }
    
    private void OnGameOver()
    {
        Exit();
        playerAnimator.enabled = false;
        gameOverState.Enter();
    }

    protected override void OnDisable()
    {
        base.OnDisable();

        levelController.enabled = false;
        playerController.enabled = false;

        GameEvent.onCollisionStone += OnGameOver;
    }
}
