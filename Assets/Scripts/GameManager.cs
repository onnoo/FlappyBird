using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState
{
    title,
    inGame,
    gameOver
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameState currentGameState;

    public int score;
    public int highscore;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        instance = this;
    }

    void Start()
    {
        currentGameState = GameState.title;
    }

    //called to start the game
    public void GameStart()
    {
        SceneManager.LoadScene("InGameScene");
        SetGameState(GameState.inGame);
    }

    //called when player die
    public void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
        SetGameState(GameState.gameOver);
    }

    //called when player decide to go back to the title
    public void BackToTitle()
    {
        SceneManager.LoadScene("TitleScene");
        SetGameState(GameState.title);
    }

    //called when player decide to quit
    public void GameExit()
    {
        Application.Quit();
    }

    void SetGameState(GameState newGameState)
    {
        if (newGameState == GameState.title)
        {
            //setup Unity scene for title state
        }
        else if (newGameState == GameState.inGame)
        {
            //setup Unity scene for inGame state
        }
        else if (newGameState == GameState.gameOver)
        {
            //setup Unity scene for gameOver state
        }

        currentGameState = newGameState;
    }
}
