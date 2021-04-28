using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointT2 : MonoBehaviour
{
    public GameObject HalfPointTrig;
    public GameObject LapCompleteTrig;
    public int counter = 0;

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            counter++;
            

            LapCompleteTrig.SetActive(true);
            HalfPointTrig.SetActive(false);
            
            yield return new WaitForSeconds(0.02f);
        }
        //counter++;
        //if (counter == 2)
        //{
        //    var objectCollider = LapCompleteTrig.GetComponent<Collider>();
        //    //objectCollider.isTrigger = false;
        //}
        //LapCompleteTrig.SetActive(true);
        ////HalfPointTrig.SetActive(false);

    }
}
