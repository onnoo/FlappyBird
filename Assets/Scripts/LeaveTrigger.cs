using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ChunkGenerator.instance.RemoveOldestChunk();
            ChunkGenerator.instance.AddChunk();
        }
    }
}
