using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] GameObject onPlay, OffPlay;
    [SerializeField] AudioSource bgmSource;

    private bool muted = false;

    private void Awake()
    {
        bgmSource = GameObject.FindGameObjectWithTag("bgm").GetComponent<AudioSource>();
    }

    void Start()
    {
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else
        {
            Load();
        }
        UpdateButtonIcon();
        PlayStopBGM();
    }

    void PlayStopBGM() // Buat cek lagi di mute atau ngga.
    {
        if (muted) // Kalo iya di mute audio source bgmnya
        {
            bgmSource.Pause();
        }
        else // Kalo ngga di play audio source bgmnya
        {
            bgmSource.Play();
        }
    }

    public void OnButtonPress()
    {
        if (muted == false)
        {
            muted = true;
        }
        else
        {
            muted = false;
        }
        PlayStopBGM();
        Save();
        UpdateButtonIcon();
    }

    public void SaveBGM()
    {
        Save();
    }

    private void UpdateButtonIcon()
    {
        if (muted == false)
        {
            onPlay.SetActive(true);
            OffPlay.SetActive(false);
        }
        else
        {
            onPlay.SetActive(false);
            OffPlay.SetActive(true);
        }
    }

    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    private void Save()
    {
        Debug.Log("Save Sukses");
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }

}
