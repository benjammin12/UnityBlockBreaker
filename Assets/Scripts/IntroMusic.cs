using UnityEngine;
using System.Collections;

public class IntroMusic : MonoBehaviour {

	static IntroMusic instance = null;

	void Start() {
		if (instance != null) {
			Destroy (gameObject);
			print ("Music Stopped");
		} else {
            instance = this;
			GameObject.DontDestroyOnLoad (gameObject); // Game Object in this case is the Intro Music component we created that holds music
		}	
	}
}
