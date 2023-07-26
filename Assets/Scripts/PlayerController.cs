using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Vector2 move;
    private Animator anim;
    private bool isFacingRight = true;
    private Rigidbody2D rb;
    [SerializeField] float speed = 2f;
    private void Reset() {
        speed = 2f;
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        Player_Animation();
        PlayerMove();
    }
    
    private void PlayerMove()
    {
        //note: the rigidbody velocity is run at the base ms/s no need the time.deltaTime
        rb.velocity = new Vector2(move.x * speed, rb.velocity.y);
        Player_flip();
    }

    public void Player_Animation()
    {
        //move left-right animation
        anim.SetFloat("move", Mathf.Abs(move.x));
    }
    //read the move input WASD form input action using invoke unity callback
    public void OnMove(InputAction.CallbackContext ctx)
    {
        move = ctx.ReadValue<Vector2>();
    }
    public void Player_flip()
    {
        //check if player facing right and player push left key the code will rotate player 180 angle and oposite
        if ((isFacingRight && move.x < 0) || (!isFacingRight && move.x > 0))
        {
            isFacingRight = !isFacingRight;
            transform.localScale = new Vector3(isFacingRight ? 1 : -1, 1, 1);
        }
    }
}
