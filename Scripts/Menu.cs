using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [Header("Regalo 1 (Scene 2)")]
    public GameObject regalo1Cerrado;
    public GameObject regalo1Abierto;

    [Header("Regalo 2 (Scene 3)")]
    public GameObject regalo2Cerrado;
    public GameObject regalo2Abierto;

    [Header("Regalo 3 (Scene 4)")]
    public GameObject regalo3Cerrado;
    public GameObject regalo3Abierto;

    public void Play()
    {
        SceneManager.LoadScene(5);
    }

    public void Credits()
    {
        SceneManager.LoadScene(6);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void OpenFirstGift()
    {
        StartCoroutine(SecuenciaAbrirRegalo(regalo1Cerrado, regalo1Abierto, 2));
    }

    public void OpenSecondGift()
    {
        StartCoroutine(SecuenciaAbrirRegalo(regalo2Cerrado, regalo2Abierto, 3));
    }

    public void OpenThirdGift()
    {
        StartCoroutine(SecuenciaAbrirRegalo(regalo3Cerrado, regalo3Abierto, 4));
    }

    IEnumerator SecuenciaAbrirRegalo(GameObject cerrado, GameObject abierto, int indiceEscena)
    {
        if (cerrado != null) cerrado.SetActive(false);
        if (abierto != null) abierto.SetActive(true);

        yield return new WaitForSeconds(3.0f);

        SceneManager.LoadScene(indiceEscena);
    }

    public void Next()
    {
        SceneManager.LoadScene(1);
    }


    public void Exit()
    {
        Application.Quit();
    }
}
