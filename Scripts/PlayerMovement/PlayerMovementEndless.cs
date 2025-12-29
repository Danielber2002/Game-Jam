using UnityEngine;

public class PlayerControllerEndless : MonoBehaviour
{
    [Header("Configuracion de Movimiento")]
    public float jumpForce = 5f;
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator playerAnimator;

    private bool isGrounded = true;

    void Start()
    {
        if (rb == null) rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(moveX * moveSpeed, rb.linearVelocity.y);


        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }

        playerAnimator.SetFloat("SpeedX", moveX);
    }

    void Jump()
    {
        rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        isGrounded = false; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}