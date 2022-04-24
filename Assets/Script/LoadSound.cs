using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSound : MonoBehaviour
{
    public void ButtonSFXInGame()
    {
        SoundManager.Instance.ButtonSFX();
    }
    
    public void DropSFXInGame()
    {
        SoundManager.Instance.DropSFX();
    }

}
