using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class reverseScript2 : MonoBehaviour
{
    
    public GameObject Car2;
    void Update()
    {
        //Debug.Log("It should work!");

        //Rigidbody rv1 = new Rigidbody();
        //rv1 = Car2.GetComponent<Rigidbody>();


        //rv1.drag = 5f;
        //rv1.AddForce(-300, 0, 0, ForceMode.Impulse);
        StartCoroutine(waiter());
    }


    IEnumerator waiter()
    {
        if (Car2.GetComponent<CarController>().CurrentSpeed < 1)
        {

            yield return new WaitForSeconds(3);
            if (Car2.GetComponent<CarController>().CurrentSpeed < 1)
            {
                Rigidbody rv = Car2.GetComponent<Rigidbody>();
                

                rv.drag = 0.1f;
                rv.AddForce(-5000, 0, 100, ForceMode.Impulse);
                rv.AddForce(0, 0, 1000, ForceMode.Impulse);


                //rv.AddForce(brakeForce * Time.deltaTime);
                //rv.AddForce(-rv.velocity*Time.deltaTime);


                Debug.Log("It should work");
                yield return new WaitForSeconds(2);
                rv.drag = 0.1f;
                //rv.AddForce(600, 0, 0, ForceMode.Impulse);

            }




        }






    }


}
