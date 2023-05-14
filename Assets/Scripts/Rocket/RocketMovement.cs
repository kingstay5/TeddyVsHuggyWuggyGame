using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    

    private void FixedUpdate()
    {
        transform.Translate(Vector3.up * Time.deltaTime * _speed);
    }
}
