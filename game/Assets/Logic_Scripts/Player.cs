using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Player : MonoBehaviour
{
    public float moveSpeed = 50f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;
    private Vector2 mousePosition;

    //public GameObject debug;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (animator)
        {
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);
        }

        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //debug.transform.position = mousePosition;

    }

    void FixedUpdate()
    {
        //var moveDirection = (-transform.right * movement.y + -transform.up * movement.x).normalized;
        //rb.MovePosition(rb.position + new Vector2(moveDirection.x, moveDirection.y) * moveSpeed * Time.fixedDeltaTime);
        rb.velocity = new Vector2(movement.x, movement.y) * moveSpeed * Time.fixedDeltaTime;
        var direction = new Vector2(transform.position.x, transform.position.y) - mousePosition;
        var rotation = Quaternion.LookRotation(direction);
        rb.MoveRotation(rotation);
    }
}
