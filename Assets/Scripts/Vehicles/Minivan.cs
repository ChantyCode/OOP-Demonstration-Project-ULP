using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minivan : Car //INHERITANCE
{
    private float minivan_motorForce = 140.0f;
    //POLYMORPHISM
    public override void HandleMotor()
    {
        frontLeftCollider.motorTorque = minivan_motorForce * verticalInput;
        frontRightCollider.motorTorque = minivan_motorForce * verticalInput;
    }
}
