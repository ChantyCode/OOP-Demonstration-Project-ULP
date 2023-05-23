using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mustang : Car //INHERITANCE
{
    private float mustang_motorForce = 160.0f;
    //POLYMORPHYSM
    public override void HandleMotor()
    {
        frontLeftCollider.motorTorque = mustang_motorForce * verticalInput;
        frontRightCollider.motorTorque = mustang_motorForce * verticalInput;
    }
}
