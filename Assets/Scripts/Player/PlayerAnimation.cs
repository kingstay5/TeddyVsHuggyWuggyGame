using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Joystick _joystick;

    private Animator _animator;
    private float _dirXjoystic;
    private float _dirXinput;
    private enum _movementState { idle, leftStrafe, rightStrafe }
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        _dirXjoystic = _joystick.Horizontal;
        _dirXinput = Input.GetAxis("Horizontal");
        PlayerAnimationUpdate();
    }
    private void PlayerAnimationUpdate()
    {
        _movementState state;
        if (_dirXinput > 0f || _dirXjoystic > 0f)
        {
            state = _movementState.rightStrafe;
        }
        else if (_dirXinput < 0f || _dirXjoystic < 0f)
        {
            state = _movementState.leftStrafe;
        }
        else
        {
            state = _movementState.idle;
        }
        _animator.SetInteger("state", (int)state);
    }
}
