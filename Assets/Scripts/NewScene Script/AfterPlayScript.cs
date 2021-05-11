using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AfterPlayScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Training()
    {
        SceneManager.LoadScene("ModifiedUnityCar");
    }
    public void BestLap()
    {
        SceneManager.LoadScene("New Scene");
    }
    public void Competition()
    {
        SceneManager.LoadScene(0);
    }
    public void RestartCompetition()
    {
        SceneManager.LoadScene(0);
    }

   
}
