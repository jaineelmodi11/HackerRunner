using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;

    public float moveSpeed = 200f;
    Vector2 movement;
    // Start is called before the first frame update

    void Update(){

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }
}
