using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
	private LevelManager lm;
    public AudioClip lose;

	void OnTriggerEnter2D (Collider2D trigger) {
        Brick.numBricks = 0; //when you lose reset the number of bricks to 0, otherwise you'll have remaining bricks + current bricks
		lm = GameObject.FindObjectOfType<LevelManager>(); //level manager looks for a game object of level manager
        AudioSource.PlayClipAtPoint(lose, Camera.main.transform.position);
        lm.LoadLevel ("Lose");

	}

	void OnCollision2D(Collision2D collision) {
        print ("Collision");
	}

}
