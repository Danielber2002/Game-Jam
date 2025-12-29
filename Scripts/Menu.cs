using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene(1);
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
        SceneManager.LoadScene(2);
    }

    public void OpenSecondGift()
    {
        SceneManager.LoadScene(3);
    }

    public void OpenThirdGift()
    {
        SceneManager.LoadScene(4);
    }


    public void Exit()
    {
        Application.Quit();
    }
}
