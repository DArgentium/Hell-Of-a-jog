using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterJump : MonoBehaviour
{
    private Vector3 jump;
    [SerializeField] private float jumpForce = 2.0f;

    private bool isGrounded;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 3.0f, 0.0f);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}
