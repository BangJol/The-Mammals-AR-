using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutUS : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Radhit()
    {
        Application.OpenURL("https://www.instagram.com/radhityaarp/");
    }
    public void Raihan()
    {
        Application.OpenURL("https://www.instagram.com/raihan_r_rizqullah/");
    }
    public void Zolla()
    {
        Application.OpenURL("https://www.instagram.com/zolla_rzq/");
    }
}
