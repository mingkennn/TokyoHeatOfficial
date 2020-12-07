using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script to allow the player to pilot the car 

public class SimpleCarController : MonoBehaviour
{
    // This is to avoid the car from flipping over when turning at high speed
    public float mass = -0.9f;

    void Start()
    {
        GetComponent<Rigidbody>().centerOfMass = new Vector3(0f, mass, 0f);
    }

    // Retrieve the user input. Horizontal used for turning left and right whereas vertical used for accelerating and decelerating
    public void GetInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    // Function allows steering of the front wheels using the horizontal user input
    public void Steer()
    {
        steeringAngle = maxSteerAngle * horizontalInput;
        leftFrontWheel.steerAngle = steeringAngle;
        rightFrontWheel.steerAngle = steeringAngle;
    }

    // This function allows the car to move by rotating the front wheels
    public void Accelerate()
    {
        rightFrontWheel.motorTorque = verticalInput * carForce;
        leftFrontWheel.motorTorque = verticalInput * carForce;
    }

    // Update the rotation and positions of the wheels
    public void UpdateWheelPoses()
    {
        UpdateWheelPose(rightFrontWheel, rightFrontTransform);
        UpdateWheelPose(leftFrontWheel, leftFrontTransform);
        UpdateWheelPose(rightRearWheel, rightRearTransform);
        UpdateWheelPose(leftRearWheel, leftRearTransform);
    }

    // Helper method which takes a collider and a transform of the vehicle's wheels
    public void UpdateWheelPose(WheelCollider collider, Transform transform)
    {
        Vector3 pos = transform.position;
        Quaternion quat = transform.rotation;

        collider.GetWorldPose(out pos, out quat);

        transform.position = pos;
        transform.rotation = quat;
    }

    // Executes the functions
    public void FixedUpdate()
    {
        GetInput();
        Steer();
        Accelerate();
        UpdateWheelPoses();

    }

    // Plays the acceleration sound when keys are pressed down but stops when the key is up (not pressed)  
    void Update()
    {
        if (Input.GetKeyDown(accelkey1) || Input.GetKeyDown(accelkey2))
        {
            accelAudioSource.Play();

        }
        else if (Input.GetKeyUp(accelkey1) || Input.GetKeyUp(accelkey2))
        {
            accelAudioSource.Stop();
        }
    }

    // Function allows sound to be played when the car collides with another object or surface
    void OnCollisionEnter(Collision collision)
    {
        crashAudioSource.Play();
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
    public AudioSource accelAudioSource;
    public AudioSource crashAudioSource;
    public AudioSource driftAudioSource;
    public KeyCode accelkey1;
    public KeyCode accelkey2;
    




}
