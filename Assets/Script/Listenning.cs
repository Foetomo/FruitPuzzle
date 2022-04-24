using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listenning : MonoBehaviour
{
    [Header("Listening")]
    public GameObject parentListening;

    [Header("Listening")]
    int order = 0;
    public AudioSource[] listen;

    void Listening()
    {
        if (order == 0)
        {
            Debug.Log("Suara Apel");
            listen[1].Play();
        }
        else if (order == 1)
        {
            Debug.Log("Suara Pisang");
        }
        else if (order == 2)
        {
             Debug.Log("Suara Cherry");
        }

    }

    public void ClickPlay()
    {
        Listening();
    }
}
