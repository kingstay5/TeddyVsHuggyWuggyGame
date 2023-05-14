using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public static EnemyDamage instance;
    public float Damage;

    private void Awake()
    {
        instance= this;
        Damage = PlayerPrefs.GetFloat("Enemy damage");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth.instance.PlayerTakeDamage(Damage);
            Destroy(gameObject);
        }
    }
}
