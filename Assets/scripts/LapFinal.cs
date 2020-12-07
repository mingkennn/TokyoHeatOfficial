using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//The script checks whether or not the player has finished the race.
//The script updates the best time values to the players quickest time.

public class LapFinal : MonoBehaviour
{
    public GameObject CheckPointFinal;
    public GameObject CheckPoint1; 

    public GameObject MinuteLap;
    public GameObject SecondLap;
    public GameObject MilliSeconds;
    public GameObject CurrentLap;
    public int LapsComplete;
    public float bestTime;
    public GameObject LapTimeBox;
    public GameObject positionDisplay;
    public GameObject LapTimer;
    public Rigidbody player;
    public GameObject WinButton;
    public GameObject LoseButton;

    

    void OnTriggerEnter(Collider other)
    {   
        if (other.tag =="carPosition")
        {
            LapsComplete = LapsComplete + 1;

            if (LapsComplete > 3)
            {

            LapTimer.SetActive(false);
            


                if (positionDisplay.GetComponent<Text>().text == "1st")
                {
                    WinButton.SetActive(true);
                    player.GetComponent<Rigidbody>().isKinematic = false;

                }

                if (positionDisplay.GetComponent<Text>().text == "2nd")

                {
                    LoseButton.SetActive(true);
                    player.GetComponent<Rigidbody>().isKinematic = false;

                }
            }

            

            bestTime = PlayerPrefs.GetFloat ("goodTime");

            if (Timer.goodTime > bestTime)
            {
                if (Timer.SecondLap <=9)
                {
                    SecondLap.GetComponent<Text>().text = "0" + Timer.SecondLap + ".";
                }
                else
                {
                    SecondLap.GetComponent<Text>().text = "" + Timer.SecondLap + ".";
                }

                if (Timer.MinuteLap <=9)
                {
                    MinuteLap.GetComponent<Text>().text = "0" + Timer.MinuteLap + ".";
                }
                else
                {
                    MinuteLap.GetComponent<Text>().text = "" + Timer.MinuteLap + ".";
                }
            }
            PlayerPrefs.SetFloat("bestTime", Timer.goodTime);

            Timer.MinuteLap = 0;
            Timer.SecondLap = 0;
            Timer.MilliSecondLap = 0;
            Timer.goodTime =0;
            CurrentLap.GetComponent<Text>().text = "" + LapsComplete;

            CheckPoint1.SetActive(true);
            CheckPointFinal.SetActive(false);
        }      
    }
}
