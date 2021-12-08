using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(Rigidbody))]

public class Jump : MonoBehaviour
{
    [SerializeField] private InputActionReference jump;
    [SerializeField] private float jumpForce = 200.0f;
    private Rigidbody body;
    private bool IsGrounded => Physics.Raycast(
        new Vector2(transform.position.x, transform.position.y + 2.0f),
        Vector3.down, 2.0f);
    void Start()
    {
        body = GetComponent<Rigidbody>();
        jump.action.performed += OnJump;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnJump(InputAction.CallbackContext obj)
    {
        if (!IsGrounded) return;
        body.AddForce(Vector3.up * jumpForce);
    }
}
