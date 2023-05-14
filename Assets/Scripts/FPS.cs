using System.Net.Sockets;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FPS : MonoBehaviour
{
    private float fpsValue;
    [SerializeField] private Text fpsText;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        fpsValue = 1.0f / Time.deltaTime;
        fpsText.text = "FPS: " + (int)fpsValue;
    }
}
