using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    [SerializeField] private AudioSource _clickSFX;
    public void Restart()
    {
        _clickSFX.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        DefaultSettings.instance.ResetOnRestart();
    }
}
