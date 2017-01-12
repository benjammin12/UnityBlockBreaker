using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){ // function that takes in a string name representing the level it's going to load
	
		Application.LoadLevel (name);
	}

	public void QuitGame(){ // function that takes in a string name representing the level it's going to load
		Application.Quit();
		//quit does not work on web builds or debug mode like you use in unity!
		//don't use application.quit for mobile development, better to let the user and the operating system control it

	}

	public void LoadNextLevel() {
		Application.LoadLevel(Application.loadedLevel+1);
	}
}
