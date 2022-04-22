using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
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
