using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void WinGame()
    {
        SceneManager.LoadScene(3);
    }

    public void LoseGame()
    {
        SceneManager.LoadScene(4);
    }
}

