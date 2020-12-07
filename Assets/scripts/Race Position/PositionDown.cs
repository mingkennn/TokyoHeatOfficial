using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Converts the players position to second place.

public class PositionDown : MonoBehaviour
{
    public GameObject positionDisplay;

    void OnTriggerExit(Collider other)
    {
    	if (other.tag == "carPosition")
    	{
    		positionDisplay.GetComponent<Text>().text = "2nd";
    	}
    }
}
