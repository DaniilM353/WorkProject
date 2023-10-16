using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayState : GameState
{
    public LevelController levelController;
    public PlayerController playerController;
    public GameState gameOverState; 

    protected override void OnEnable()
    { 
        base.OnEnable();

        levelController.enabled = true;
        playerController.enabled = true;

        GameEvent.onCollisionStone += OnGameOver;
    }

    private void OnGameOver()
    {
        Exit();
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
