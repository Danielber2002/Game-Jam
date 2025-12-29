using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [Header("Configuración")]
    public float tiempoInicial = 60f;
    public Text textoDelReloj;

    private float tiempoRestante;
    private bool tiempoTerminado = false;

    void Start()
    {
        tiempoRestante = tiempoInicial;
    }

    void Update()
    {
        if (tiempoTerminado) return;

        if (tiempoRestante > 0)
        {
            tiempoRestante -= Time.deltaTime;
            ActualizarTexto(tiempoRestante);
        }
        else
        {
            tiempoRestante = 0;
            tiempoTerminado = true;
            ActualizarTexto(0);

            StartCoroutine(SecuenciaFinJuego());
        }
    }

    void ActualizarTexto(float tiempo)
    {
        textoDelReloj.text = Mathf.CeilToInt(tiempo).ToString();
    }

    System.Collections.IEnumerator SecuenciaFinJuego()
    {

        Time.timeScale = 0;

        yield return new WaitForSecondsRealtime(3f);

        Time.timeScale = 1;

        SceneManager.LoadScene(1);
    }
}