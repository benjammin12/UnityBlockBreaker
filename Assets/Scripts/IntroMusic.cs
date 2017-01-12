using UnityEngine;
using System.Collections;

public class IntroMusic : MonoBehaviour {

	static IntroMusic instance = null;

	void Awake() {
		if (instance != null) {
			Destroy (gameObject);
			print ("Music Stopped");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject); // Game Object in this case is the Intro Music component we created that holds music
		}	
	}


	// Use this for initialization
	void Start () {

	}


	

	
	// Update is called once per frame
	void Update () {


	}
}
