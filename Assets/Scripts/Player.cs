using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.VersionControl.Asset;

public class Player : MonoBehaviour
{
    InputAction moveAction;

    public int speed;

    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel;

        float magnitude = rb.linearVelocity.magnitude;

        if(moveAction.IsPressed())
        {
            vel = transform.forward * speed;
        }
        else
        {
            vel = transform.forward * 0f;
        }

        rb.linearVelocity = new Vector3(vel.x, rb.linearVelocity.y, vel.z);
    }
} 
