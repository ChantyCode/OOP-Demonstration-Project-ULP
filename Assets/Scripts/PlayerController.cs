using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float verticalInput;
    private float horizontalInput;
    private Rigidbody rb;
    
    public float speed = 5.0f; //To be validated with encapsulation
    public float turningSpeed = 5.0f; //To be validated with encapsulation
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        
        rb.AddForce(new Vector3(gameObject.transform.localRotation.x, 0, 0) * speed * Time.deltaTime * verticalInput, ForceMode.Acceleration);
        
        horizontalInput = Input.GetAxis("Horizontal");

        rb.AddRelativeTorque(Vector3.up * turningSpeed * Time.deltaTime * horizontalInput, ForceMode.Acceleration);
    }
}
