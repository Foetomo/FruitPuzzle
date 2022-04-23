using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedBack : MonoBehaviour
{
    public GameObject panelGreat, penutup;
    bool selesai = false;

    // Script untuk mengecek ketika puzzle sudah selesai
    public void check()
    {
        for (int i = 0; i < 4; i++)
        {
            if (transform.GetChild(i).GetComponent<Drag>().onPaste)
            {
                selesai = true;
            }
            else
            {
                selesai = false;
                i = 4;
            }
        }

        if (selesai)
        {
            panelGreat.gameObject.SetActive(true);
            penutup.gameObject.SetActive(true);
        }
    }

    public void Update()
    {
        if (!selesai)
        {
            check();
        }
    }
}
