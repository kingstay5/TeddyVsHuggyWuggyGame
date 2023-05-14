using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartAd : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void RestartAdvExtern();

    public void RestartAdvButton()
    {
        RestartAdvExtern();
        AudioListener.volume = 0f;
    }
    public void RestartLevel()
    {
        AudioListener.volume = 1f;
        DefaultSettings.instance.ResetOnRestart();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
