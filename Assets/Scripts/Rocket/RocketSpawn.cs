using UnityEngine;

public class RocketSpawn : MonoBehaviour
{
    public static RocketSpawn instance;

    public float AttackSpeed;

    [SerializeField] private GameObject _rocket;
    [SerializeField] private GameObject _spawnPoint;
    [SerializeField] private float _countdown;
    [SerializeField] private AudioSource _shootSFX;

    private void Start()
    {
        instance = this;
        AttackSpeed = PlayerPrefs.GetFloat("Attack speed");
    }
    private void Update()
    {
        if (_countdown <= 0)
        {
            _shootSFX.Play();
            Instantiate(_rocket, _spawnPoint.transform.position, _rocket.transform.rotation);
            _countdown = 1 / AttackSpeed;
        }
        _countdown -= Time.deltaTime;
    }
}
