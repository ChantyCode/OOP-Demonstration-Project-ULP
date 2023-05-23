using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    //Input
    protected float verticalInput;
    protected float horizontalInput;

    protected float currentBreakForce;
    protected float currentSteerAngle;
    protected bool isBreaking;

    //Inspector variables
    [SerializeField] protected float motorForce = 150.0f; //To be validated with encapsulation
    [SerializeField] protected float breakingForce = 1250.0f; //To be validated with encapsulation
    [SerializeField] protected float maxSteeringAngle = 30.0f; //To be validated with encapsulation

    //Wheel Colliders
    [SerializeField] protected WheelCollider frontLeftCollider;
    [SerializeField] protected WheelCollider frontRightCollider;
    [SerializeField] protected WheelCollider rearLeftCollider;
    [SerializeField] protected WheelCollider rearRightCollider;

    //Weel Transforms
    [SerializeField] protected Transform frontLeftTransform;
    [SerializeField] protected Transform frontRightTransform;
    [SerializeField] protected Transform rearLeftTransform;
    [SerializeField] protected Transform rearRightTransform;
    void FixedUpdate()
    {
        //ABSTRACTION
        GetInput();
        HandleMotor();
        HandleSteering();
    }

    private void GetInput()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        isBreaking = Input.GetKey(KeyCode.Space);
    }
    public virtual void HandleMotor()
    {
        frontLeftCollider.motorTorque = motorForce * verticalInput;
        frontRightCollider.motorTorque = motorForce * verticalInput;
        currentBreakForce = isBreaking ? breakingForce : 0.0f;
        if (isBreaking)
        {
            ApplyBreaking();
        }
    }
    public virtual void ApplyBreaking()
    {
        frontLeftCollider.brakeTorque = currentBreakForce;
        frontRightCollider.brakeTorque = currentBreakForce;
        rearLeftCollider.brakeTorque = currentBreakForce;
        rearRightCollider.brakeTorque = currentBreakForce;
    }
    public virtual void HandleSteering()
    {
        currentSteerAngle = maxSteeringAngle * horizontalInput;
        frontLeftCollider.steerAngle = currentSteerAngle;
        frontRightCollider.steerAngle = currentSteerAngle;
    }
}
