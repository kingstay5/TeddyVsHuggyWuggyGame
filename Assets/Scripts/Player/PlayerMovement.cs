using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 10.0f;
    [SerializeField] private float _horizontalInput;
    [SerializeField] private float _joystickHorisontalInput;
    [SerializeField] private Joystick _joystick;
    private readonly float _xRange = 10;
    void FixedUpdate()
    {
        PlayerMove();
        MoveBorder();
    }
    private void PlayerMove()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _joystickHorisontalInput = _joystick.Horizontal;
        transform.Translate(Vector3.right * _horizontalInput * Time.deltaTime * _speed);
        transform.Translate(Vector3.right * _joystickHorisontalInput * Time.deltaTime * _speed);
    }
    private void MoveBorder()
    {
        if (transform.position.x < -_xRange)
        {
            transform.position = new Vector3(-_xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > _xRange)
        {
            transform.position = new Vector3(_xRange, transform.position.y, transform.position.z);
        }
    }
}
