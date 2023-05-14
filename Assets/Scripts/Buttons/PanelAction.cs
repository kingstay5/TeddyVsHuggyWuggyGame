using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelAction : MonoBehaviour
{
    [SerializeField] private GameObject _targetPanel;
    [SerializeField] private GameObject _hudPanel;
    [SerializeField] private AudioSource _clickSFX;

    public void OpenPanel()
    {
        _clickSFX.Play();
        _targetPanel.SetActive(true);
        _hudPanel.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ClosePanel()
    {
        _clickSFX.Play();
        _targetPanel.SetActive(false);
        _hudPanel.SetActive(true);
        Time.timeScale = 1f;
    }
}
