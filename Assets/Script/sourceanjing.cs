using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sourceanjing : MonoBehaviour
{
    public AudioSource lagu;
    public void Mulai()
    {
        lagu.Play();
    }

    public void Stoplagu()
    {
        lagu.Stop();
    }
}
