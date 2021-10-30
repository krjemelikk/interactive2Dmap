using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Animator))]
public class Player : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private Vector2 _moveDirection;
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        GetMoveAxis();
        Move();
    }

    private void GetMoveAxis()
    {
        _moveDirection.x = Input.GetAxis("Horizontal");
        _moveDirection.y = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        _rigidbody2D.MovePosition(_rigidbody2D.position + _moveDirection * _moveSpeed * Time.fixedDeltaTime);

        _animator.SetFloat("Horizontal", _moveDirection.x);
        _animator.SetFloat("Vertical", _moveDirection.y);
        _animator.SetFloat("Speed", _moveDirection.sqrMagnitude);
    }
}
