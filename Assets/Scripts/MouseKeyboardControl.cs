using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseKeyboardControl : MonoBehaviour
{
    public Camera mainCamera;
    public Animator animator;
    public bool moving
    {
        get
        {
            if (animator == null)
            {
                animator = gameObject.GetComponent<Animator>();
            }
            return animator.GetBool("Moving");
        }
        set
        {
            if (animator == null)
            {
                animator = gameObject.GetComponent<Animator>();
            }
            animator.SetBool("Moving", value);
        }
    }
    public float speed = 10f;
    public float rotationSpeed = 10f;
    public float verticalInput;
    public float horizontalInput;
    private Vector3 moveDirection;

    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        if (verticalInput != 0 || horizontalInput != 0)
        {
            moving = true;
        }
        else
        {
            moving = false;
        }

        moveDirection = new Vector3(horizontalInput, 0, verticalInput);
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);

        if (moveDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveDirection);
        }
    }

    void LateUpdate()
    {
        mainCamera.transform.position = transform.position + new Vector3(0, 10, -10);
        mainCamera.transform.LookAt(transform.position);
    }
}
