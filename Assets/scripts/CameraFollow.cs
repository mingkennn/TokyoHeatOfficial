using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public void LookAtSubject()
    {
        Vector3 direction = subject.position - transform.position;
        Quaternion rotate = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotate, lookSpeed * Time.deltaTime);
    }

    public void MoveToSubject()
    {
        Vector3 targetPosition = subject.position +
                                 subject.forward * offset.z +
                                 subject.right * offset.x +
                                 subject.up * offset.y;
        transform.position = Vector3.Lerp(transform.position, targetPosition, cameraSpeed * Time.deltaTime);
    }

    public void Update()
    {
        LookAtSubject();
        MoveToSubject();
    }

    public Transform subject;
    public Vector3 offset;
    public float cameraSpeed = 10;
    public float lookSpeed = 10;
}
