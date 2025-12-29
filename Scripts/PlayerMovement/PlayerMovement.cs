using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    [Header("Configuracion de Movimiento")]
    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    [Header("Ajustes de Pantalla")]
    public float padding = 0.5f; 
    private Vector2 minBounds;
    private Vector2 maxBounds;
    public Animator playerAnimator;

    void Start()
    {

        Camera cam = Camera.main;

        minBounds = cam.ViewportToWorldPoint(new Vector3(0, 0, 0));
        maxBounds = cam.ViewportToWorldPoint(new Vector3(1, 1, 0));
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        playerAnimator.SetFloat("SpeedX", moveX);
        playerAnimator.SetFloat("SpeedY", moveY);

        Vector2 movement = new Vector2(moveX, moveY).normalized;

        Vector2 newPos = rb.position + movement * moveSpeed * Time.fixedDeltaTime;

        newPos.x = Mathf.Clamp(newPos.x, minBounds.x + padding, maxBounds.x - padding);
        newPos.y = Mathf.Clamp(newPos.y, minBounds.y + padding, maxBounds.y - padding);

        rb.MovePosition(newPos);
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.CompareTag("Enemy"))
        {
            rb.linearVelocity = Vector2.zero;
            rb.bodyType = RigidbodyType2D.Static;

            GetComponent<Collider2D>().enabled = false;

            this.enabled = false;

            Animator anim = GetComponent<Animator>();
            if (anim != null)
            {
                anim.enabled = false; 
            }

            Invoke("GameOver", 2f);

        }

    }

    private void GameOver()
    {
        SceneManager.LoadScene(1);
    }

}