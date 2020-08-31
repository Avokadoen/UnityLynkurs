using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidbody2D;

    [SerializeField] 
    private float moveSpeed = 0.2f;
    
    [SerializeField] 
    private float jumpHeight = 4f;

    public bool isColliding = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = 0;
        if (rigidbody2D.velocity.x < 2) {
            horizontal = Input.GetAxis("Horizontal") * moveSpeed;
        }

        float vertical = 0;
        if (isColliding) {
            vertical = Input.GetAxis("Vertical") * jumpHeight;
        } 

        rigidbody2D.AddForce(new Vector2(horizontal, vertical), ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isColliding = true;
    }

    void OnCollisionExit2D(Collision2D collisionInfo)
    {
        isColliding = false;
    }
}
