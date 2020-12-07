using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    
    public void GetInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    public void Steer()
    {
        steeringAngle = maxSteerAngle * horizontalInput;
        leftFrontWheel.steerAngle = steeringAngle;
        rightFrontWheel.steerAngle = steeringAngle;
    }

    public void Accelerate()
    {
        rightFrontWheel.motorTorque = verticalInput * carForce;
        leftFrontWheel.motorTorque = verticalInput * carForce;
    }

    public void UpdateWheelPoses()
    {
        UpdateWheelPose(rightFrontWheel, rightFrontTransform);
        UpdateWheelPose(leftFrontWheel, leftFrontTransform);
        UpdateWheelPose(rightRearWheel, rightRearTransform);
        UpdateWheelPose(leftRearWheel, leftRearTransform);
    }

    public void UpdateWheelPose(WheelCollider collider, Transform transform)
    {
        Vector3 pos = transform.position;
        Quaternion quat = transform.rotation;

        collider.GetWorldPose(out pos, out quat);

        transform.position = pos;
        transform.rotation = quat;
    }

    public void FixedUpdate()
    {
        GetInput();
        Steer();
        Accelerate();
        UpdateWheelPoses();
    }

    private float horizontalInput;
    private float verticalInput;
    private float steeringAngle;

    public WheelCollider rightFrontWheel, leftFrontWheel;
    public WheelCollider rightRearWheel, leftRearWheel;
    public Transform rightFrontTransform, leftFrontTransform;
    public Transform rightRearTransform, leftRearTransform;
    public float maxSteerAngle = 45;
    public float carForce = 70;

}
