using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketDamage : MonoBehaviour
{
    public static RocketDamage instance;
    public float Damage;

    private void Start()
    {
        instance = this;
        Damage = PlayerPrefs.GetFloat("Hero damage");
    }
    private void OnTriggerEnter(Collider other)
    {
        EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.EnemyTakeDamage(Damage);
            Destroy(gameObject);
        }
    }
}
