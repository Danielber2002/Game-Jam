using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Método para iniciar el juego
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Método para salir del juego
    public void Exit()
    {
        Debug.Log("Se pulsó en el botón Salir.");
        Application.Quit();
    }
}
