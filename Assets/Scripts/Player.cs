using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private RaycastHit2D hit;
    public Animator animator;

    Vector2 movement;
    // Start is called before the first frame update
    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();

        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        // Getting input for movement
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // getting animation combined with movement
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        //Reset moveDelta
        moveDelta = new Vector3(movement.x, movement.y, 0);

        //Making sure to move in this direction by castinga box first (x-axis)
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        
        if (hit.collider== null)
        {
            //Moving
            transform.Translate(0,moveDelta.y * Time.deltaTime,0);
        }

        //Making sure to move in this direction by castinga box first (y-axis)
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(moveDelta.x,0), Mathf.Abs(moveDelta.x * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));

        if (hit.collider == null)
        {
            //Moving
            transform.Translate(moveDelta.x * Time.deltaTime, 0,0);
        }










    }
}
