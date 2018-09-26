using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAction : MonoBehaviour
{
    public void GameStart()
    {
        GameManager.instance.GameStart();
    }
    public void GameOver()
    {
        GameManager.instance.GameOver();
    }
    public void BackToTitle()
    {
        GameManager.instance.BackToTitle();
    }
}
