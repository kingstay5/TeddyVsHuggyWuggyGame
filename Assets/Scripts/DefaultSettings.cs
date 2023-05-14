using UnityEngine;

public class DefaultSettings : MonoBehaviour
{
    public static DefaultSettings instance;

    [Header("Player settings")]
    [SerializeField] private float _playerDamage;
    [SerializeField] private float _playerAttackSpeed;
    [Header("Enemy settings")]
    [SerializeField] private float _enemyDamage;
    [SerializeField] private float _enemyMaxHealth;
    [SerializeField] private float _enemyKillReward;
    [SerializeField] private float _enemySpawnSpeed;
    [SerializeField] private float _enemyMovementSpeed;

    void Awake()
    {
        instance = this;
        Time.timeScale = 1f;

        Application.targetFrameRate = 300;
        PlayerPrefs.SetFloat("Hero damage", _playerDamage);
        PlayerPrefs.SetFloat("Attack speed", _playerAttackSpeed);
        PlayerPrefs.SetFloat("Enemy damage", _enemyDamage);
        PlayerPrefs.SetFloat("Enemy health", _enemyMaxHealth);
        PlayerPrefs.SetFloat("Enemy reward", _enemyKillReward);
        PlayerPrefs.SetFloat("Enemy spawn speed", _enemySpawnSpeed);
        PlayerPrefs.SetFloat("Enemy movement speed", _enemyMovementSpeed);
    }
    public void ResetOnRestart()
    {
        PlayerPrefs.DeleteKey("Hero damage");
        PlayerPrefs.DeleteKey("Attack speed");
        PlayerPrefs.DeleteKey("Enemy damage");
        PlayerPrefs.DeleteKey("Enemy health");
        PlayerPrefs.DeleteKey("Enemy reward");
        PlayerPrefs.DeleteKey("Enemy spawn speed");
        PlayerPrefs.DeleteKey("Enemy movement speed");
    }
}
