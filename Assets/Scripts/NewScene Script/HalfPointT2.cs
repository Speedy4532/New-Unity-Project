using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointT2 : MonoBehaviour
{
    public GameObject HalfPointTrig;
    public GameObject LapCompleteTrig;

    void OnTriggerEnter()
    {
        LapCompleteTrig.SetActive(true);
        HalfPointTrig.SetActive(false);

    }
}
