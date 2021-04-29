using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class Countdo : MonoBehaviour
{
    public GameObject CountDown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public AudioSource OnGameAudio;
    public GameObject LapTimer;
    public GameObject starter;
    public GameObject CarControl;
    public GameObject reverse;
    void Start()
    {
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        CountDown.GetComponent<Text>().text = "3";
        GetReady.Play();
        CountDown.SetActive(true);

        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "2";
        GetReady.Play();
        CountDown.SetActive(true);

        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "1";
        GetReady.Play();
        CountDown.SetActive(true);

        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        GoAudio.Play();
        OnGameAudio.Play();



        LapTimer.SetActive(true);
        CarControl.SetActive(true);
        //yield return new WaitForSeconds(4);
        reverse.SetActive(true);


        // starter.SetActive(false);



    }
    //void Update()
    //{
    //    StartCoroutine(Audio());
    //}
    //IEnumerator Audio()
    //{
    //    yield return new WaitForSeconds(5);
      
    //}


}
