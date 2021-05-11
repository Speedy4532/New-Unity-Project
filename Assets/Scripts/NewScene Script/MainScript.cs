using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour
{
    public GameObject Panel1;
    public GameObject Panel2;

    public void Play()
    {
        SceneManager.LoadScene("AfterPlay");
    }
    public void GetInOption()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(true);
    }
    public void GetOutOption()
    {
        Panel1.SetActive(true);
        Panel2.SetActive(false);
    }
}
