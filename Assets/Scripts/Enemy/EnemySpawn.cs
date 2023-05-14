using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public static EnemySpawn instance;

    public float SpawnSpeed;
    [Space]
    [SerializeField] private GameObject[] _enemy;
    [SerializeField] private GameObject[] _spawnPoint;
    [SerializeField] private float _countdown;

    private void Start()
    {
        instance = this;
        SpawnSpeed = PlayerPrefs.GetFloat("Enemy spawn speed");
    }
    private void Update()
    {
        for (int i = 0; i < _enemy.Length; i++)
        {
            int enemyIndex = Random.Range(0, _enemy.Length);
            int spawnIndex = Random.Range(0, _spawnPoint.Length);

            if (_countdown <= 0)
            {
                Instantiate(_enemy[enemyIndex], _spawnPoint[spawnIndex].transform.position, _enemy[enemyIndex].transform.rotation);
                _countdown = 1 / SpawnSpeed;
            }
        }
        _countdown -= Time.deltaTime;
    }

}
