using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MainMenuState : GameState
{
    public GameState gamePlayState;

    public void PlayGame()
    {

        Exit();
        gamePlayState.Enter();

    }
}
