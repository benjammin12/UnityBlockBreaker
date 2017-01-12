using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	private LevelManager lm;
	private int numHits;

	public Sprite[] hitSprites;

	void Start () {
		lm = GameObject.FindObjectOfType<LevelManager>(); 
		numHits = 0;
	
	}

	// Update is called once per frame
	void Update () {

	}

	
	void OnCollisionEnter2D(Collision2D col) {
		bool isBreakable = (this.tag == "Breakable");
		if (isBreakable) {
			HandleHits();
		}
	}

	void HandleHits() {
		numHits++;
		int maxHits = hitSprites.Length + 1;
		if(numHits >= maxHits){ 
			Destroy(gameObject); //used to destroy the game object
		}else { loadSprite(); } 
	}

	void loadSprite() {
		int spriteIndex = numHits - 1;

		if (hitSprites[spriteIndex]){ //if sprite has something in it's index
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];   // go to spriterender in the brick inspector and
		}																		//go to the sprite section and changes its value

	}

	void simulateWin(){
		lm.LoadNextLevel();
	}
}
