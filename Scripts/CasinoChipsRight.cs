using UnityEngine;

public class CasinoChipsRight : MonoBehaviour
{
    public float fuerza = 10f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Diagonal: (1 en X, 1 en Y)
        Vector2 direccion = new Vector2(-1, 1).normalized;
        rb.AddForce(direccion * fuerza, ForceMode2D.Impulse);
    }
}