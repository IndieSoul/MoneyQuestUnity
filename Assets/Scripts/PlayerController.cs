using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 mousePosition;
    private Rigidbody2D rb;
    private Animator animatorPlayer;
    private SpriteRenderer spriteRendererPlayer;
    private float direction = 0;
    private float mousePosX;
    private float mousePosY;
    [SerializeField]
    private float moveSpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animatorPlayer = GetComponent<Animator>();
        spriteRendererPlayer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            mousePosX = mousePosition.x - transform.position.x;
            mousePosY = mousePosition.y - transform.position.y;
            direction = mousePosX;
        } else {
            direction = 0;
        }
    }

    private void FixedUpdate() {
        if (direction > 0.2) 
        {
            rb.velocity = Vector2.right * moveSpeed * Time.deltaTime;
            animatorPlayer.SetBool("isWalking", true);
            spriteRendererPlayer.flipX = false;
        }
        if (direction < -0.2) 
        {
            rb.velocity = -Vector2.right * moveSpeed * Time.deltaTime;
            animatorPlayer.SetBool("isWalking", true);
            spriteRendererPlayer.flipX = true;
        }

        if (direction < 0.2 && direction > -0.2) 
        {
            rb.velocity = Vector2.zero;
            animatorPlayer.SetBool("isWalking", false);
        }
    }
}
