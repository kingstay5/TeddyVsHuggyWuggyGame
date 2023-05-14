using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class StartAdv : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowAdv();

    private void Start()
    {
        AudioListener.volume = 0f;
        ShowAdv();
    }

    public void VolumeOn()
    {
        AudioListener.volume = 1f;
    }
}
