using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovementHero : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float speed;
    [SerializeField] private float horizontalSpeed;
    [SerializeField] private float jumpSpeed;
    [SerializeField] private float gravity;
    private Animator animator;
    private float floor;
    private bool isJumping =  false;
    private Vector2 velocity;
    private Rigidbody2D playerRgbd;


    private void OnEnable()
    {
        
        InputManager.PlayerJump += Jump;
        HeroLife.DeathAction += OnDeath;
    }

    private void OnDisable()
    {
        HeroLife.DeathAction -= OnDeath;
        InputManager.PlayerJump -= Jump;
    }

    
    void Start()
    {
        playerRgbd = player.GetComponent<Rigidbody2D>();
        animator = player.GetComponent<Animator>();
    }

    
    void FixedUpdate()
    {
        Move();
        OnJump();
    }

    private void Move()
    {
        playerRgbd.transform.position = new Vector2(playerRgbd.transform.position.x + speed * Time.deltaTime, playerRgbd.position.y);
    }


    private void Jump()
    {
        if (!isJumping)
        {
            isJumping = true;
            animator.SetBool("isJumping", true);
            velocity.y = jumpSpeed;
            floor = transform.position.y;
        }
    }

    private void OnJump()
    {
        Vector2 pos = transform.position;
        

        if (isJumping)
        {
            pos.y += velocity.y * Time.fixedDeltaTime;
            velocity.y += gravity * Time.fixedDeltaTime;

            if (pos.y <= floor)
            {
                pos.y = floor;
                isJumping = false;
                animator.SetBool("isJumping", false);
            }   
        }

        transform.position = pos;
    }

    private void OnDeath()
    {
        animator.SetBool("IsDead", true);
        this.speed = 0;
    }

}
