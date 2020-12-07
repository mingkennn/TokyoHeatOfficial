using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Intiates the 3..2..1.. countdown present at the begining of every race.
//The ending of the countdown begins the timer and allows the character to begin moving.

public class Countdown : MonoBehaviour
{
	public GameObject CountDown;
	public GameObject LapTimer;
    public Rigidbody player;
     

    void Start()
    {
        StartCoroutine(count());
    }

    IEnumerator count() 
    {
    	CountDown.GetComponent<Text>().text = "3";
    	CountDown.SetActive(true);
    	yield return new WaitForSeconds(1);
    	CountDown.SetActive(false);
    	CountDown.GetComponent<Text>().text = "2";
    	CountDown.SetActive(true);
    	yield return new WaitForSeconds(1);
    	CountDown.SetActive(false);
    	CountDown.GetComponent<Text>().text = "1";
    	CountDown.SetActive(true);
    	yield return new WaitForSeconds(1);
    	CountDown.SetActive(false);
    	LapTimer.SetActive(true);
        player.GetComponent<Rigidbody>().isKinematic = false;
      

    }
}
