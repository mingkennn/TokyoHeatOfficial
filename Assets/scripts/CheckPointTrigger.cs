using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script checks whether or not the player has passed the required checkpoint.
//The script stops cheating by ensuring players have finished a lap before they can progress

public class CheckPointTrigger : MonoBehaviour
{
   public GameObject CheckPointFinalTrig;
   public GameObject CheckPoint1Trig;

   void OnTriggerEnter()
   {
   	CheckPointFinalTrig.SetActive(true);
   	CheckPoint1Trig.SetActive(false);
   }
}
