using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class Pau : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject Onplay;
    public GameObject pauseMenuUI;
    public AudioSource okay;

   
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        okay.Play();
        
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Pause()
    {
        okay.Pause();
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        //Pause();
        //Resume();

    }
    public void MainMenu()
    {
        SceneManager.LoadScene(4);
    }
}
