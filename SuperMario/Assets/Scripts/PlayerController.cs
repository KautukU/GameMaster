using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    bool isGrounded = true;
    Rigidbody2D rbody;
    private Vector2 direction;
    bool isCrouching = false;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");
        float jump = Input.GetAxis("Jump");
        animator.SetFloat("xSpeed", Mathf.Abs(horiz));

        if (horiz > 0)
        {
            direction = Vector2.right;
            rbody.velocity = new Vector2(horiz * 8f, rbody.velocity.y);
            transform.right = direction;
        }
        if (horiz < 0)
        {
            direction = Vector2.left;
            rbody.velocity = new Vector2(horiz * 8f, rbody.velocity.y);
            transform.right = direction;
        }
        if (jump > 0 && isGrounded)
        {
            rbody.AddForce(Vector2.up * 20, ForceMode2D.Impulse);
            animator.SetBool("IsGrounded", false);
            isGrounded = false;
        }
        

    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground") || other.gameObject.CompareTag("Obstacles"))
        {
            animator.SetBool("IsGrounded", true);
            isGrounded = true;
        }

    }

}
