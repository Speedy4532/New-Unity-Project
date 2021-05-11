using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;
using System;


public class LapComp : MonoBehaviour
{
	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;

	//public GameObject MinuteDisplay;
	//public GameObject SecondDisplay;
	//public GameObject MilliDisplay;



    //public GameObject LapTimeBox;
    public GameObject Announcer;
	public static int count = 0;
   
    public GameObject MyCar;
    public GameObject Car1;
    public GameObject Car2;

    public GameObject Panel2;
    public GameObject Panel2Text;
    public GameObject CarControlM;
    public GameObject OnGame;
   


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
            
            if (count == 0)
			{
                
				//counter = 0;
				Announcer.GetComponent<Text>().text = "First Lap";
                
              

                yield return new WaitForSeconds(2f);
                Announcer.GetComponent<Text>().text = " ";
                HalfLapTrig.SetActive(true);
                count++;
                LapCompleteTrig.SetActive(false);
                

            }
            else if(count == 1)
            {
				Announcer.GetComponent<Text>().text = "Last Lap";
				
                yield return new WaitForSeconds(2f);
                Announcer.GetComponent<Text>().text = " ";
                HalfLapTrig.SetActive(true);
                count++;
                //CarControlM.SetActive(true);
                LapCompleteTrig.SetActive(false);
            }
            else if(count == 2)
            {
                //record the finishing time
                //MinuteFinish = Convert.ToDouble(Convert.ToString(MinuteDisplay.GetComponent<Text>().text)[:2]);
                //SecondFinish = Convert.ToDouble(SecondDisplay.GetComponent<Text>().text);
                //MilliFinish = Convert.ToDouble(MilliDisplay.GetComponent<Text>().text);



                Rigidbody rb = MyCar.GetComponent<Rigidbody>();
                rb.drag = 23f;
                Rigidbody rb2 = MyCar.GetComponent<Rigidbody>();
                rb2.drag = 23f;
                count++;
                if (count > LapCompCar1.counter && count > LapCompCar2.counter)
                {
                    Announcer.GetComponent<Text>().text = "You have won!";
                    yield return new WaitForSeconds(3f);
                    Panel2.SetActive(true);
                    Panel2Text.GetComponent<Text>().text = $"Name                 Time \n 1. You                 {LapTimeM.MinuteCount}:{LapTimeM.SecondCount}.{Math.Round(LapTimeM.MilliCount, MidpointRounding.AwayFromZero)} \n 2. Car1                 2:12:11";
                }
                else 
                {
                    Announcer.GetComponent<Text>().text = "You have lost! ";
                    yield return new WaitForSeconds(3f);
                    Panel2.SetActive(true);
                    Panel2Text.GetComponent<Text>().text = $"Name                 Time \n 1. Car1                 {LapCompCar1.MinuteFinish}:{LapCompCar1.SecondFinish}.{LapCompCar1.MilliFinish} \n 2. MyCar                 {LapTimeM.MinuteCount}:{LapTimeM.SecondCount}.{Math.Round(LapTimeM.MilliCount, MidpointRounding.AwayFromZero)}";
                }
              

                OnGame.GetComponent<AudioSource>().volume = 0.2f;
                MyCar.GetComponent<CarAudio>().enabled = false;
                Car1.GetComponent<CarAudio>().enabled = false;
                Car2.GetComponent<CarAudio>().enabled = false;

                LapCompleteTrig.SetActive(false);
            }
            



           
			
        }
      
        



    }
    //void Update()
    //{
    //    if (counterCar1 == 1 && counterCar1 > counterCar2)
    //    {
    //        Announcer.GetComponent<Text>().text = "You Have won";


    //    }
    //    else if (counterCar2 == 1 && counterCar2 > counterCar1)
    //    {
    //        Announcer.GetComponent<Text>().text = "You lost";


    //    }

    //    //    if(counter == 1)
    //    //    {
    //    //        car1.GetComponent<CarController>().enabled = false;
    //    //        car2.GetComponent<CarController>().enabled = false;
    //    //    }
    //}
}
