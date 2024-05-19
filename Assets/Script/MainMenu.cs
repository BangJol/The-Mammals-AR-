using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource lagu;
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void Play()
    {
        SceneManager.LoadScene("Play");
    }

    public void Hint()
    {
        SceneManager.LoadScene("Hint");
    }

    public void AboutUS()
    {
        SceneManager.LoadScene("About Us");
    }
}
