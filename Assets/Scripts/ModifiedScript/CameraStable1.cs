using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TheCar;
    public float CarX;
    public float CarY;
    public float CarZ;

    // Update is called once per frame
    void Update()
    {
        CarX = TheCar.transform.eulerAngles.x;
        CarY = TheCar.transform.eulerAngles.y;
        CarZ = TheCar.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3 (CarX - CarX, CarY, CarZ - CarZ);
          
    }
}
