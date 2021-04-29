using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapCompCar1 : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    public GameObject Car1;
    public static int counter = 0;
    public GameObject reverseObject;

    IEnumerator OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Car1")
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
                Rigidbody rb = Car1.GetComponent<Rigidbody>();
                rb.drag = 23f;
                Rigidbody rb2 = Car1.GetComponent<Rigidbody>();
                rb2.drag = 23f;
                counter++;

                reverseObject.SetActive(false);
            }
            






        }





    }


}
