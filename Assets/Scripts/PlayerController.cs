using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    private Rigidbody2D rigidBody;

    public float jumpForce;
    public float velocityX;
    bool isJumping;

    void Awake()
    {
        instance = this;
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump"))
        {
            isJumping = true;
        }
    }

    void FixedUpdate()
    {

        Jump();
    }

    void Jump()
    {
        if (!isJumping)
        {
            return;
        }
        //if (rigidBody.velocity.y > 0)
        //{
        //    rigidBody.velocity = new Vector2(0, 0);
        //}
        rigidBody.velocity = Vector2.zero;
        rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        isJumping = false;
    }
}
