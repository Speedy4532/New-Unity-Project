using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class WinnerChecker : MonoBehaviour
{
    public GameObject Announcer;
    
    void Update()
    {
       
       if(LapComp.count == 2 && LapCompCar1.counter<2)
       {
            //Announcer.GetComponent<Text>().text = "You have won";
            Debug.Log("Okay");
       }
       else if(LapCompCar1.counter == 2 && LapComp.count < 2)
       {
            //Announcer.GetComponent<Text>().text = "You have lost";
            Debug.Log("Okuy");

        }
    }
}
