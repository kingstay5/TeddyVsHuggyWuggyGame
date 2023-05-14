using TMPro;
using UnityEngine;

public class EnemyWaveBuff : MonoBehaviour
{
    public static EnemyWaveBuff instance;
    [Header("Enemy prefab")]
    [SerializeField] private EnemyHealth[] _enemyHealth;
    [SerializeField] private EnemyDamage[] _enemyDamage;
    [SerializeField] private EnemyKillReward[] _enemyReward;
    [Header("Wave stats")]
    [SerializeField] private int _currentWave;
    [SerializeField] private int _currentKills;
    [SerializeField] private int _targetKills;
    [Header("Multiply value")]
    [SerializeField] private float _enemyHealthBuffMultiply;
    [SerializeField] private float _ememyDamageBuffMultiply;
    [SerializeField] private float _enemyKillRewardMultiply;
    [SerializeField] private float _enemyMovementSpeedMultiply;
    [SerializeField] private float _enemySpawnSpeedMultiply;
    [Header("Texts")]
    [SerializeField] private TextMeshProUGUI _targetKillsText;
    [SerializeField] private TextMeshProUGUI _currentWaveText;
    [Header("End game stats")]
    private int _defeatedEnemys;
    [SerializeField] private TextMeshProUGUI _completedWavesText;
    [SerializeField] private TextMeshProUGUI _defeatedEnemysText;
    [Space]
    [SerializeField] private Animator[] _anim;
    private void Awake()
    {
        instance = this;
        _defeatedEnemys = 0;
    }
    private void Update()
    {
        _currentWaveText.text = _currentWave.ToString();
        _targetKillsText.text = _currentKills + "/" + _targetKills;
        _defeatedEnemysText.text = _defeatedEnemys.ToString();
        _completedWavesText.text = _currentWave.ToString();
        CompleteWave();
    }
    public void CompleteWave()
    {
        if (_currentKills >= _targetKills)
        {
            _anim[0].SetTrigger("Shake");
            _currentWave++;
            _currentKills = 0;
            _targetKills += 5;
            EnemyBuff();
            EnemyStatsUpdate();
            DialogBox.instance.EnableDialog();
        }
    }
    public void KillDetect()
    {
        _anim[1].SetTrigger("Shake");
        _currentKills += 1;
        _defeatedEnemys += 1;
    }
    private void EnemyBuff()
    {
        PlayerPrefs.SetFloat("Enemy health", EnemyHealth.instance.MaxHealth * _enemyHealthBuffMultiply);
        PlayerPrefs.SetFloat("Enemy damage", EnemyDamage.instance.Damage * _ememyDamageBuffMultiply);
        PlayerPrefs.SetFloat("Enemy reward", EnemyKillReward.instance.KillReward * _enemyKillRewardMultiply);
        PlayerPrefs.SetFloat("Enemy spawn speed", EnemySpawn.instance.SpawnSpeed + _enemySpawnSpeedMultiply);
        PlayerPrefs.SetFloat("Enemy movement speed", EnemyMovement.instance.Speed + _enemyMovementSpeedMultiply);
    }
    private void EnemyStatsUpdate()
    {
        PlayerPrefs.GetFloat("Enemy health");
        PlayerPrefs.GetFloat("Enemy damage");
        PlayerPrefs.GetFloat("Enemy reward");
        PlayerPrefs.GetFloat("Enemy spawn speed");
        PlayerPrefs.GetFloat("Enemy movement speed");
    }
}
