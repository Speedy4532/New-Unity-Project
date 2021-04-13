using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LapComp : MonoBehaviour
{
	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;

	public GameObject MinuteDisplay;
	public GameObject SecondDisplay;
	public GameObject MilliDisplay;

	public GameObject LapTimeBox;

	void OnTriggerEnter()
	{

		if (LapTimeM.SecondCount <= 9)
		{
			SecondDisplay.GetComponent<Text>().text = "0" + LapTimeM.SecondCount + ".";
		}
		else
		{
			SecondDisplay.GetComponent<Text>().text = "" + LapTimeM.SecondCount + ".";
		}

		if (LapTimeM.MinuteCount <= 9)
		{
			MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeM.MinuteCount + ".";
		}
		else
		{
			MinuteDisplay.GetComponent<Text>().text = "" + LapTimeM.MinuteCount + ".";
		}

		MilliDisplay.GetComponent<Text>().text = "" + LapTimeM.MilliCount;

		LapTimeM.MinuteCount = 0;
		LapTimeM.SecondCount = 0;
		LapTimeM.MilliCount = 0;

		HalfLapTrig.SetActive(true);
		LapCompleteTrig.SetActive(true);
	}
}
