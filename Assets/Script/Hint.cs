using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hint : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Download()
    {
        Application.OpenURL("https://bit.ly/46Ew8hY");
    }
}
