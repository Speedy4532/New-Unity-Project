using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapCompCar2 : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    public GameObject Car2;
    public static int counter = 0;
    public GameObject reverseObject;

    IEnumerator OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Car2")
        {

            if (counter == 0)
            {

                //counter = 0;
                //Announcer.GetComponent<Text>().text = "First Lap";


                Debug.Log("Haha");
                yield return new WaitForSeconds(2f);
                //Announcer.GetComponent<Text>().text = " ";
                counter++;
                HalfLapTrig.SetActive(true);
                LapCompleteTrig.SetActive(false);


            }
            else if (counter == 1)
            {
                //Announcer.GetComponent<Text>().text = "Last Lap";

                yield return new WaitForSeconds(2f);
                //Announcer.GetComponent<Text>().text = " ";
                counter++;
                HalfLapTrig.SetActive(true);
                //CarControlM.SetActive(true);
                LapCompleteTrig.SetActive(false);
            }
            else if (counter == 2)
            {
                Rigidbody rb = Car2.GetComponent<Rigidbody>();
                rb.drag = 23f;
                Rigidbody rb2 = Car2.GetComponent<Rigidbody>();
                rb2.drag = 23f;
                counter++;

                reverseObject.SetActive(false);
            }







        }





    }

}
