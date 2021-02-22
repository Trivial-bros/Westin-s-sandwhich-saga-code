using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float speed;
    public float jumpforce;
    float moveinput;

    Rigidbody2D rb;
    public Animator animator;
    public GameObject doubleJumpUI;
    public Audio_Manager audio_Manager;

    bool facingright = true;
    bool isGrounded;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    private int extraJumps;
    public int extraJumpsValue;

    float jumptimecounter;
    public float jumptime;

    private void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        if(isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0){
            rb.velocity = Vector2.up * jumpforce; 
            extraJumps--;
        } else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpforce;

        }
        if (Input.GetKeyDown(KeyCode.W) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpforce;
            extraJumps--;
        }
        else if (Input.GetKeyDown(KeyCode.W) && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpforce;

        }
        if (Input.GetKeyDown(KeyCode.Space) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpforce;
            extraJumps--;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpforce;

        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            audio_Manager.Play("Jump");
            animator.SetTrigger("jump");
        }
        if (Input.GetKeyDown(KeyCode.W) &&
            isGrounded == true)
        {
            audio_Manager.Play("Jump");
            animator.SetTrigger("jump");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded == true)
        {
            audio_Manager.Play("Jump");
            animator.SetTrigger("jump");
        }

        if(extraJumps == 0)
        {
            doubleJumpUI.SetActive(false);
        }
        else
        {
            doubleJumpUI.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        moveinput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveinput * speed, rb.velocity.y);

        if(facingright == false && moveinput > 0)
        {
            flip();
        }
        else if (facingright == true && moveinput < 0)
        {
            flip();
        }
    }

    void flip()
    {
        facingright = !facingright;
        transform.Rotate(0f, 180f, 0f);
    }
}
