using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    [Header("BGM Button")]
    public GameObject onPlayBGM;
    public GameObject offMuteBGM;

    [Header("SFX Button")]
    public GameObject onPlaySFX;
    public GameObject offMuteSFX;


    public void ButtonBGMMute()
    {
        if (SoundManager.Instance.bgm.mute == false)
        {
            onPlayBGM.gameObject.SetActive(false);
            offMuteBGM.gameObject.SetActive(true);
        }
        else
        {
            onPlayBGM.gameObject.SetActive(true);
            offMuteBGM.gameObject.SetActive(false);
        }
        SoundManager.Instance.ButtonBGMMute();
    }

    public void ButtonSFXMute()
    {
        if (SoundManager.Instance.sfx.mute == false)
        {
            onPlaySFX.gameObject.SetActive(false);
            offMuteSFX.gameObject.SetActive(true);
        }
        else
        {
            onPlaySFX.gameObject.SetActive(true);
            offMuteSFX.gameObject.SetActive(false);
        }
        SoundManager.Instance.ButtonSFXMute();
    }

    public void ButtonSFX()
    {
        SoundManager.Instance.ButtonSFX();
    }
    
    public void DropSFX()
    {
        SoundManager.Instance.DropSFX();
    }

    // Untuk pindah dari scene ke scene berikutnya
    public void LoadScene(string namescene) 
    {
        Debug.Log("Berhasil Pindah Scene " + namescene);
        SceneManager.LoadScene(namescene);
    }

    // Untuk keluar aplikasi
    public void Quit()
    {
        Debug.Log("Berhasil Keluar");
        Application.Quit();
    }
}
