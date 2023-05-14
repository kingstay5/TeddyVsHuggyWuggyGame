using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseShop : MonoBehaviour
{
    [SerializeField] private GameObject _shopPanel;
    [SerializeField] private GameObject _openButton;
    [SerializeField] private GameObject _settingsButton;
    [SerializeField] private AudioSource _clickSFX;

    public void CloseShopPanel()
    {
        _clickSFX.Play();
        _shopPanel.SetActive(false);
        _openButton.SetActive(true);
        _settingsButton.SetActive(true);
        Time.timeScale = 1.0f;
    }
}
