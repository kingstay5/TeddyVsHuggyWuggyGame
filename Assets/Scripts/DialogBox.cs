using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogBox : MonoBehaviour
{
    public static DialogBox instance;

    [SerializeField] private GameObject _dialogPanel;
    [Space]
    [SerializeField] private AudioSource _sfx;
    [Space]
    [SerializeField] private int _wave;
    [SerializeField] private TextMeshProUGUI _waveText;
    [Header("In")]
    [SerializeField] private float _scaleX;
    [SerializeField] private float _scaleY;
    [SerializeField] private float _scaleZ;
    [SerializeField] private float _scaleDuration;
    [SerializeField] private float _scaleDelay;
    [Header("Out")]
    [SerializeField] private float _outScaleX;
    [SerializeField] private float _outScaleY;
    [SerializeField] private float _outScaleZ;
    [SerializeField] private float _outScaleDuration;
    [SerializeField] private float _outScaleDelay;
    public void Awake()
    {
        instance = this;
        EnableDialog();
    }
    public void EnableDialog()
    {
        Invoke("PlaySFX", _scaleDelay);
        _wave++;
        _waveText.text = _wave.ToString();
        LeanTween.scale(_dialogPanel, new Vector3(_scaleX, _scaleY, _scaleZ), _scaleDuration).setDelay(_scaleDelay).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(_dialogPanel, new Vector3(_outScaleX, _outScaleY, _outScaleZ), _outScaleDuration).setDelay(_outScaleDelay).setEase(LeanTweenType.easeOutCubic);
    }
    private void PlaySFX()
    {
        _sfx.Play();
    }

}
