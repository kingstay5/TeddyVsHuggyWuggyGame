using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBorder : MonoBehaviour
{
    [SerializeField] private float _border;

    private void Update()
    {
        if (transform.position.z > _border)
        {
            Destroy(gameObject);
        }
    }
}
