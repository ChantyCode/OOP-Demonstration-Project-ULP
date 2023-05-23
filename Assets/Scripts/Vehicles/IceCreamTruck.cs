using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCreamTruck : Car //INHERITANCE
{
    //POLYMORPHISM
    private float iceCreamTruck_motorForce = 125.0f;
    public override void HandleMotor()
    {
        frontLeftCollider.motorTorque = iceCreamTruck_motorForce * verticalInput;
        frontRightCollider.motorTorque = iceCreamTruck_motorForce * verticalInput;
    }
}
