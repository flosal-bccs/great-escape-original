﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour {

	public void PlayGame()
	{
		SceneManager.LoadScene ("EnterName");
	}

    public void ResumeGame()
    {
        
        SceneManager.LoadScene("Level1");
    }

	public void GoToBoss(){
		SceneManager.LoadScene ("Boss Battle");
	}

	public void GoToInstructions(){
		SceneManager.LoadScene ("Instructions");
		// continue animation for instructions scene
		Time.timeScale = 1f;
	}

	public void StartOver(){
		SceneManager.LoadScene ("TitleScreen");
	}

	public void Settings(){
		SceneManager.LoadScene ("Settings");
	}

	public void QuitGame()
	{
        PlayerPrefs.DeleteKey("CurrentPlayer");
		Application.Quit ();
	}

	public void GoToWelcome(){
		SceneManager.LoadScene ("Welcome");
	}

	public void GoToEnterName(){
		SceneManager.LoadScene ("EnterName");
	}

	public void GoToReview1(){
		SceneManager.LoadScene ("Review1");
	}

	public void GoToLevel2(){
		SceneManager.LoadScene ("Level2");
	}

	public void HomeScreen(){
		SceneManager.LoadScene ("Home");
	}

	public void GoToNextLevel(){
		//BookScript.bookControl.ResetBooks ();
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // go to next level in game
	}
}
