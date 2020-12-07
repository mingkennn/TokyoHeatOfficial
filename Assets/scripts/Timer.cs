using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//A timer to keep track of how long it has taken the player to complete a single lap

public class Timer : MonoBehaviour
{
    public static int MinuteLap;
    public static int SecondLap;
    public static float MilliSecondLap;
    public static string Mil;

    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MilDisplay;

    public static float goodTime;

    

    IEnumerator count()
    {
        yield return new WaitForSeconds(3);
    } 
           

    void Start()
    {
        StartCoroutine(count());
    }

    
    void Update()
    {
        MilliSecondLap += Time.deltaTime * 10;
        goodTime += Time.deltaTime;
        Mil = MilliSecondLap.ToString("F0");
        MilDisplay.GetComponent<Text>().text = "" + Mil;

        if (MilliSecondLap >= 10)
        {
        	MilliSecondLap = 0;
        	SecondLap +=1;
        }

        if (SecondLap <=9)
        {
        	SecDisplay.GetComponent<Text>().text = "0" + SecondLap + ".";
        }
        else
        {
        	SecDisplay.GetComponent<Text>().text = "" + SecondLap + ".";
        }

        if (SecondLap == 60)
        {
        	SecondLap =0;
        	MinuteLap +=1;
        }

        if(MinuteLap <=9)
        {
        	MinDisplay.GetComponent<Text>().text = "0" + MinuteLap + ":" ;
        }
        else
        {
        	MinDisplay.GetComponent<Text>().text = "" + MinuteLap + ":" ;
        }

    }
}
