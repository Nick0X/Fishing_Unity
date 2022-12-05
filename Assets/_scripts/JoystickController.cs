using UnityEngine;

//[RequireComponent(typeof(Rigidbody), typeof (CapsuleCollider))]

public class JoystickController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private Animator _animator;

    [SerializeField] private float _moveSpeed;

    private void FixedUpdate()
    {     
      _rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidbody.velocity.y, _joystick.Vertical * _moveSpeed); 

      if(_joystick.Horizontal !=0 || _joystick.Vertical !=0)
      {
        transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
        Debug.Log("velocity = " + _rigidbody.velocity);
        _animator.SetBool("walk", true);
      } 
      else _animator.SetBool("walk", false);
    }

}