using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string inputID;

    [SerializeField] float speed = 20.0f;
    [SerializeField] float turnSpeed = 45.0f;
    private float forwardInput;
    private float horizontalInput;

    void FixedUpdate()
    {
        forwardInput = Input.GetAxis("Vertical" + inputID);
        horizontalInput = Input.GetAxis("Horizontal" + inputID);

        // Move the vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Rotate the vehicle based on horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
