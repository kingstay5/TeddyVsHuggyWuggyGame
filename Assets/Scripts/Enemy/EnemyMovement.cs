using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public static EnemyMovement instance;

    public float Speed;

    private void Start()
    {
        instance = this;
        Speed = PlayerPrefs.GetFloat("Enemy movement speed");
    }
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
    }
}
