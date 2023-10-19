using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverState : GameState
{
    public GameState mainMenuState;
    public LevelController levelController;

    public void Restart()
    {
        levelController.ClearStone();
        playerAnimator.enabled = false;
        
        Exit();
        mainMenuState.Enter();
        
    }
}
