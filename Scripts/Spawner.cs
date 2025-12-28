using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    [Header("Lista de Objetos")]
    public GameObject[] objetosParaSpawnear;

    public GameObject objetoVisual;

    [Header("Configuración de Tiempos")]
    public float tiempoMinimo = 1.0f; 
    public float tiempoMaximo = 3.0f; 

    [Header("Dificultad Progresiva")]
    public float reduccionPorSpawn = 0.25f; 
    public float tiempoLimite = 0.5f;       

    [Header("Límites X")]
    public float minX = -8f;
    public float maxX = 8f;

    void Start()
    {
        if (objetoVisual != null) objetoVisual.SetActive(false);
        StartCoroutine(GenerarObjetos());
    }

    IEnumerator GenerarObjetos()
    {
        yield return new WaitForSeconds(1.0f); 

        while (true)
        {
           
            float InicialWait = Random.Range(tiempoMinimo, tiempoMaximo);
            yield return new WaitForSeconds(InicialWait);

            if (objetoVisual != null)
            {
                StartCoroutine(ActivarVisualTemporalmente());
            }

            int index = Random.Range(0, objetosParaSpawnear.Length);
            GameObject objeto = objetosParaSpawnear[index];

            float xAleatorio = Random.Range(minX, maxX);
            Vector2 pos = new Vector2(xAleatorio, transform.position.y);

            Instantiate(objeto, pos, Quaternion.identity);
            

            float wait = Random.Range(tiempoMinimo, tiempoMaximo);
            yield return new WaitForSeconds(wait);

            if (tiempoMaximo > tiempoLimite)
            {
                tiempoMaximo -= reduccionPorSpawn;
            }

            if (tiempoMinimo > tiempoLimite)
            {
                tiempoMinimo -= reduccionPorSpawn;
            }

            tiempoMinimo = Mathf.Max(tiempoMinimo, tiempoLimite);
            tiempoMaximo = Mathf.Max(tiempoMaximo, tiempoLimite);
        }
    }
    IEnumerator ActivarVisualTemporalmente()
    {
        objetoVisual.SetActive(true);        
        yield return new WaitForSeconds(1.0f); 
        objetoVisual.SetActive(false);       
    }
}