using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void GoToStageSelection()
    {
        SceneManager.LoadScene(1);
    }
    public void Stage1()
    {
        SceneManager.LoadScene("Game");
    }
     public void Stage2()
    {
        SceneManager.LoadScene("Game-2");
    }
     public void Stage3()
    {
        SceneManager.LoadScene("Game-3");
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void GoToOptions()
    {
        SceneManager.LoadScene("Option");
    }
    public void GoToCredits()
    {
        SceneManager.LoadScene("Credit");
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Pause()
    {
        Time.timeScale = 0;
    }
    public void Resume()
    {
        Time.timeScale = 1;
    }
    public void Retry()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    public void GoToHighScore()
    {
        SceneManager.LoadScene("HighScore");
    }
}
