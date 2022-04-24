using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; set; }

    [Header("Audio Source")]
    public AudioSource bgm;
    public AudioSource sfx;
    public AudioSource drop;

    private void Awake()
    {
        bgm = transform.GetChild(0).GetComponent<AudioSource>();
        sfx = transform.GetChild(1).GetComponent<AudioSource>();

        DontDestroyOnLoad(this);
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ButtonBGMMute()
    {
        if (bgm.mute == false)
        {
            bgm.mute = true;
        }
        else
        {
            bgm.mute = false;
        }
    }

    public void ButtonSFX()
    {
        sfx.Play();
    }
    
    public void DropSFX()
    {
        drop.Play();
    }

    public void ButtonSFXMute()
    {
        if (sfx.mute == false && drop.mute == false)
        {
            sfx.mute = true;
            drop.mute = true;
        }
        else
        {
            sfx.mute = false;
            drop.mute = false;
        }
    }

}
