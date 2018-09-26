using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public Transform exitPoint;
    public float VelocityX;
    private Rigidbody2D rb2d;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    public void MoveStart()
    {
        rb2d.velocity = new Vector2(VelocityX, 0.0f);
    }
}
