using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] bool groundedPlayer;
    [SerializeField] float playerSpeed = 2.0f;
    [SerializeField] float jumpHeight = 1.0f;
    [SerializeField] float downwardMovementMultiplier = 3f;
    [SerializeField] float upwardMovementMultiplier = 1.7f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Check if the player is grounded
        groundedPlayer = Physics2D.OverlapCircle(transform.position, 0.2f, LayerMask.GetMask("Floor"));

        if (groundedPlayer && rb.velocity.y < 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0f);
        }

        Vector2 move = new Vector2(Input.GetAxis("Horizontal"), 0);
        rb.velocity = new Vector2(move.x * playerSpeed, rb.velocity.y);

        if (move != Vector2.zero)
        {
            transform.right = move;
        }

        // Jump
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            if (groundedPlayer)
            {
                rb.velocity = new Vector2(rb.velocity.x, Mathf.Sqrt(jumpHeight * -2f * Physics2D.gravity.y));
            }
        }

        if (rb.velocity.y > 0)
        {
            rb.gravityScale = upwardMovementMultiplier;
        }
        else if (rb.velocity.y < 0)
        {
            rb.gravityScale = downwardMovementMultiplier;
        }
        else
        {
            rb.gravityScale = 1f;
        }
    }
}
