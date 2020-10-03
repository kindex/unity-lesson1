using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class TankControls : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<WheelJoint2D>().useMotor = true;
            var jointMotor2D = GetComponent<WheelJoint2D>().motor;
            jointMotor2D.motorSpeed = 1000;
            GetComponent<WheelJoint2D>().motor = jointMotor2D;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            GetComponent<WheelJoint2D>().useMotor = true;
            var jointMotor2D = GetComponent<WheelJoint2D>().motor;
            jointMotor2D.motorSpeed = -1000;
            GetComponent<WheelJoint2D>().motor = jointMotor2D;
        }
        else
        {
            GetComponent<WheelJoint2D>().useMotor = false;
        }
    }
}
