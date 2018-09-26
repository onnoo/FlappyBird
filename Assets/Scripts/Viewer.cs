using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Viewer : MonoBehaviour
{
    public static Viewer instance;
    public Text scoreLabel;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        scoreLabel.text = GameManager.instance.score.ToString();
    }

    public void UpdateState()
    {
        scoreLabel.text = GameManager.instance.score.ToString();
    }
}
