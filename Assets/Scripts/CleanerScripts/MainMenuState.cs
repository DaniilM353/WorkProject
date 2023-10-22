using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MainMenuState : GameState
{
    public LevelController levelController;
    public GameState gamePlayState;
    public TMP_Text scoreText;

    public void PlayGame()
    {

        Exit();
        gamePlayState.Enter();
        playerAnimator.enabled = true;
        playerAnimator.SetFloat("Speed Multiplier", 0);
    }

    protected override void OnEnable()
    { 
        base.OnEnable();

        scoreText.text = $" HScore : {levelController.hightScore}";
    }
}
 