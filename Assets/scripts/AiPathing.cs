using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiPathing : MonoBehaviour
{
    float currentTime = 0.0f;
    float startingTime = 3f;
    bool autoStart = false;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += 1 * Time.deltaTime;

        if (currentTime == 3.0f)
        {
            autoStart = true;
        }
    }
}
