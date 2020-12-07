using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedometer : MonoBehaviour
{

    //The Angles at Mininum and Max Speed
    private const float MAX_SPEED_ANGLE = -180;
    private const float ZERO_SPEED_ANGLE = 0;

    //For the needle to rotate the Z axis
    public Transform needleTransform;

    // Max intended Speeds
    private float speedMax;
    private float speed;


    private void Awake()
    {
        speed = 0f;
        speedMax = 100f;
    }

    private void Update()
    {
        //The code to transform or rotate the needle
        HandlePlayerInput();
        needleTransform.eulerAngles = new Vector3(0, 0, GetSpeedRotation());
    }

    private float GetSpeedRotation()
    {
        //The Speed to rotate

        float totalAngleSize = ZERO_SPEED_ANGLE - MAX_SPEED_ANGLE;

        float speedNormalized = speed / speedMax;

        return ZERO_SPEED_ANGLE - speedNormalized * totalAngleSize;
    }

    private void HandlePlayerInput()
    {
        //To check for player input currently 

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        { //If Up arrow or W is pressed, car accelerates
            float acceleration = 10f;
            speed += acceleration * Time.deltaTime;
        }
        else
        { //Else there is a constant deceleration like real cars
            float deceleration = 75f;
            speed -= deceleration * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.W))
        { //If Down Arrow or S is pressed, car accelerates
            float deceleration = 110f;
            speed -= deceleration * Time.deltaTime;
        }

        speed = Mathf.Clamp(speed, 0f, speedMax);
    }
}
