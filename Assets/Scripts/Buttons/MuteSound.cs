using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteSound : MonoBehaviour
{
    [SerializeField] private Sprite _volumeOn;
    [SerializeField] private Sprite _volumeOff;
    [SerializeField] private GameObject _volumeButton;
    [SerializeField] private AudioSource _clickSFX;

    private void Update()
    {
        ImageUpdate();
    }
    public void OnOffVolume()
    {
        if (AudioListener.volume == 1)
        {
            _clickSFX.Play();
            AudioListener.volume = 0;
            _volumeButton.GetComponent<Image>().sprite = _volumeOff;
        }
        else
        {
            _clickSFX.Play();
            AudioListener.volume = 1;
            _volumeButton.GetComponent<Image>().sprite = _volumeOn;
        }
    }

    private void ImageUpdate()
    {
        if (AudioListener.volume == 1)
        {
            _volumeButton.GetComponent<Image>().sprite = _volumeOn;
        }
        else
        {
            _volumeButton.GetComponent<Image>().sprite = _volumeOff;
        }
    }
}
