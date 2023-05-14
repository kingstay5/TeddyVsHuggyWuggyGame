using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth instance;
    public float _maxHealth;
    public float _currentHealth;
    [SerializeField] private TextMeshProUGUI _healthText;
    [SerializeField] private Image _healthBar;
    [SerializeField] private GameObject _deathPanel;
    [SerializeField] private GameObject _hudPanel;
    [SerializeField] private AudioSource _hitSFX;
    [SerializeField] private Animator _anim;
    private void Start()
    {
        instance = this;
        _currentHealth = _maxHealth;
        _anim.GetComponent<Animator>();
    }
    private void Update()
    {
        _healthBar.fillAmount = (float)(_currentHealth / _maxHealth);
        _healthText.text = _currentHealth.ToString("F1");
    }
    public void PlayerTakeDamage(float _damage)
    {
        _currentHealth -= _damage;
        _anim.SetTrigger("Shake");
        if (_currentHealth <= 0)
        {
            _hudPanel.SetActive(false);
            _deathPanel.SetActive(true);
            Time.timeScale = 0f;
        }
        _hitSFX.Play();
        _healthText.text = _currentHealth.ToString("F0");
    }
}
