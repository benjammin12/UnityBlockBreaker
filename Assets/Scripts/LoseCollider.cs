using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
	private LevelManager lm;

	void OnTriggerEnter2D (Collider2D trigger) {
		lm = GameObject.FindObjectOfType<LevelManager>(); //level manager looks for a game object of level manager
		lm.LoadLevel ("Lose");

	}

	void OnCollision2D(Collision2D collision) {
		print ("Collision");
	}

}
