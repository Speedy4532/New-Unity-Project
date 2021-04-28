using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;


public class LapComp : MonoBehaviour
{
	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;

	public GameObject MinuteDisplay;
	public GameObject SecondDisplay;
	public GameObject MilliDisplay;

	//public GameObject LapTimeBox;
	public GameObject Announcer;
	public int counterCar1 = -1;
    public int counterCar2 = -1;
    public GameObject car1;
    public GameObject car2;
    public GameObject CarControlM;

    //void OnTriggerEnter(Collider collision)
    //{







    //if (LapTimeM.SecondCount <= 9)
    //{
    //	SecondDisplay.GetComponent<Text>().text = "0" + LapTimeM.SecondCount + ".";
    //}
    //else
    //{
    //	SecondDisplay.GetComponent<Text>().text = "" + LapTimeM.SecondCount + ".";
    //}

    //if (LapTimeM.MinuteCount <= 9)
    //{
    //	MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeM.MinuteCount + ".";
    //}
    //else
    //{
    //	MinuteDisplay.GetComponent<Text>().text = "" + LapTimeM.MinuteCount + ".";
    //}

    //MilliDisplay.GetComponent<Text>().text = "" + LapTimeM.MilliCount;

    //LapTimeM.MinuteCount = 0;
    //LapTimeM.SecondCount = 0;
    //LapTimeM.MilliCount = 0;

    //HalfLapTrig.SetActive(true);
    //LapCompleteTrig.SetActive(true);
    //}
  

    IEnumerator OnTriggerEnter(Collider collision)
	{
		
		if (collision.gameObject.tag == "Player")
		{
            
            if (counterCar1 == -1)
			{
                
				//counter = 0;
				Announcer.GetComponent<Text>().text = "First Lap";
                
              

                yield return new WaitForSeconds(2f);
                Announcer.GetComponent<Text>().text = " ";
                HalfLapTrig.SetActive(true);
                LapCompleteTrig.SetActive(false);
                

            }
            else if(counterCar1 == 0)
            {
				Announcer.GetComponent<Text>().text = "Last Lap";
				
                yield return new WaitForSeconds(2f);
                Announcer.GetComponent<Text>().text = " ";
                HalfLapTrig.SetActive(true);
                //CarControlM.SetActive(true);
                LapCompleteTrig.SetActive(false);
            }
            else if(counterCar1 == 1)
            {
                Rigidbody rb = car1.GetComponent<Rigidbody>();
                rb.drag = 23f;
                Rigidbody rb2 = car2.GetComponent<Rigidbody>();
                rb2.drag = 23f;
            }
            



            counterCar1++;
			
        }
        else
        {
            if(counterCar2 == 1)
            {
                Rigidbody rb2 = car2.GetComponent<Rigidbody>();
                rb2.drag = 23f;
            }
            else
            {
                Rigidbody rb2 = car2.GetComponent<Rigidbody>();
                rb2.drag = 0.1f;
            }
            counterCar2++;
        }
        



    }
    void Update()
    {
        if (counterCar1 == 1 && counterCar1 > counterCar2)
        {
            Announcer.GetComponent<Text>().text = "You Have won";


        }
        else if (counterCar2 == 1 && counterCar2 > counterCar1)
        {
            Announcer.GetComponent<Text>().text = "You lost";


        }

        //    if(counter == 1)
        //    {
        //        car1.GetComponent<CarController>().enabled = false;
        //        car2.GetComponent<CarController>().enabled = false;
        //    }
    }
    }
