using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public string inputID;

    [SerializeField] float horsePower = 20.0f;
    [SerializeField] float turnSpeed = 45.0f;
    [SerializeField] TextMeshProUGUI speedometerText;
    private float forwardInput;
    private float horizontalInput;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        forwardInput = Input.GetAxis("Vertical" + inputID);
        horizontalInput = Input.GetAxis("Horizontal" + inputID);

        // Move the vehicle forward based on vertical input
        rb.AddRelativeForce(Vector3.forward * horsePower * forwardInput);

        // Rotate the vehicle based on horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }

    void Update()
    {
        float speed = Mathf.Round(rb.velocity.magnitude * 2.237f);
        speedometerText.SetText("Speed: " + speed + "mph");
    }
}
