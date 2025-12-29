using UnityEngine;
using UnityEngine.SceneManagement;

public class LegoWin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Has ganado el juego!");
            // Aquí puedes agregar lógica adicional para manejar la victoria, como cargar una nueva escena o mostrar un mensaje.

            Invoke("GameOver", 2f);
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene(1);
    }
}
