using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarContr : MonoBehaviour
{
    public GameObject CarControl;
    public GameObject CarControl2;
    public GameObject carControlM;
    // Start is called before the first frame update
    void Start()
    {
        CarControl.GetComponent<CarController>().enabled = true;
        CarControl2.GetComponent<CarController>().enabled = true;
        //carControlM.SetActive(false);
        

    }
   

}
