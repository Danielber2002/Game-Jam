using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Lore : MonoBehaviour
{
    [Header("Configuración")]
    public float tiempoEntreLetras = 0.05f;
    public string contenidoDelTexto;

    private Text miTextoUI;

    void Awake()
    {
        miTextoUI = GetComponent<Text>();
    }

    // CAMBIO: Usamos Start en lugar de OnEnable
    void Start()
    {
        // Si no escribiste nada en el inspector, toma el texto que ya tiene el objeto
        if (string.IsNullOrEmpty(contenidoDelTexto))
        {
            contenidoDelTexto = miTextoUI.text;
        }

        // Inicia la animación automáticamente al cargar la escena
        StartCoroutine(EscribirTexto());
    }

    IEnumerator EscribirTexto()
    {
        miTextoUI.text = ""; // Limpia el texto

        foreach (char letra in contenidoDelTexto.ToCharArray())
        {
            miTextoUI.text += letra;
            yield return new WaitForSeconds(tiempoEntreLetras);
        }
    }
}