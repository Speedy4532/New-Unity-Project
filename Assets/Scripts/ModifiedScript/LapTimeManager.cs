// These scripts will manage your lap times

//LAP TIME MANAGER SCRIPT
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LapTimeManager : MonoBehaviour {

	public static int MinuteCount;
	public static int SecondCount;
	public static float MilliCount;
	public static string MilliDisplay;

	public GameObject MinuteBox;
	public GameObject SecondBox;
	public GameObject MilliBox;
	

	void Update () {
		MilliCount += Time.deltaTime * 10;
		MilliDisplay = MilliCount.ToString ("F0");
		MilliBox.GetComponent<Text> ().text = "" + MilliDisplay;

		if (MilliCount >= 10) {
			MilliCount = 0;
			SecondCount += 1;
		}

		if (SecondCount <= 9) {
			SecondBox.GetComponent<Text> ().text = "0" + SecondCount + ".";
		} else {
			SecondBox.GetComponent<Text> ().text = "" + SecondCount + ".";
		}

		if (SecondCount >= 60) {
			SecondCount = 0;
			MinuteCount += 1;
		}

		if (MinuteCount <= 9) {
			MinuteBox.GetComponent<Text> ().text = "0" + MinuteCount + ":";
		} else {
			MinuteBox.GetComponent<Text> ().text = "" + MinuteCount + ":";
		}
		
	}
}


//LAP COMPLETE SCRIPT



public class LapComplete : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;

	public GameObject MinuteDisplay;
	public GameObject SecondDisplay;
	public GameObject MilliDisplay;

	public GameObject LapTimeBox;

	void OnTriggerEnter () {

		if (LapTimeManager.SecondCount <= 9) {
			SecondDisplay.GetComponent<Text> ().text = "0" + LapTimeManager.SecondCount + ".";
		} else {
			SecondDisplay.GetComponent<Text> ().text = "" + LapTimeManager.SecondCount + ".";
		}

		if (LapTimeManager.MinuteCount <= 9) {
			MinuteDisplay.GetComponent<Text> ().text = "0" + LapTimeManager.MinuteCount + ".";
		} else {
			MinuteDisplay.GetComponent<Text> ().text = "" + LapTimeManager.MinuteCount + ".";
		}

		MilliDisplay.GetComponent<Text> ().text = "" + LapTimeManager.MilliCount;

		LapTimeManager.MinuteCount = 0;
		LapTimeManager.SecondCount = 0;
		LapTimeManager.MilliCount = 0;

		HalfLapTrig.SetActive (true);
		LapCompleteTrig.SetActive (false);
	}

}
