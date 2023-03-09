using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof (BoxCollider))]
public class ControllerSystem : MonoBehaviour
{
    public static ControllerSystem instance;
    private void Awake()
    {
        instance = this;
    }
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joystick;
    private double BeforeConvertX = 0;
    private double BeforeConvertY = 0;
    public int SendToFirebaseX = 0;
    public int SendToFirebaseY = 0;

    [SerializeField] private float _moveSpeed;
    
    private void FixedUpdate()
    {

        _rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, 
            _rigidbody.velocity.y, _joystick.Vertical * _moveSpeed);
        BeforeConvertX = _joystick.Horizontal * _moveSpeed * 10.23;
        BeforeConvertY = _joystick.Vertical * _moveSpeed * 10.23; //ให้นึกเสมอว่าแกน z คือแกน y

        SendToFirebaseX = (int)BeforeConvertX;
        SendToFirebaseY = (int)BeforeConvertY;

        Debug.Log(SendToFirebaseX);
        Debug.Log(SendToFirebaseY);
        Debug.Log(_rigidbody.velocity);
        /*
        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
        }*/
    }
}