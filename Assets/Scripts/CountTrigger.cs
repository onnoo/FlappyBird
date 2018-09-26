using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.instance.score++;
        Viewer.instance.UpdateState();
    }
}
