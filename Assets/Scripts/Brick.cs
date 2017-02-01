using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
    public static int numBricks = 0;
    public AudioClip crack;
    public GameObject smoke;

	private LevelManager lm;
	private int numHits;
    private bool isBreakable;

    public Sprite[] hitSprites;

	void Start () {
        isBreakable = (this.tag == "Breakable");
        if (isBreakable){
            numBricks++;
            print(numBricks);
        }

        lm = GameObject.FindObjectOfType<LevelManager>(); 
		numHits = 0;
	
	}

	// Update is called once per frame
	void Update () {
       
	}

	
	void OnCollisionEnter2D(Collision2D col) {
		if (isBreakable) {
			HandleHits();
           }
	}


	void HandleHits() {
        numHits++;
		int maxHits = hitSprites.Length + 1;
		if(numHits >= maxHits){
            numBricks--; //decerement number of bricks before we destroy it
            AudioSource.PlayClipAtPoint(crack, this.transform.position);
            createSmoke();
            Destroy(gameObject); //used to destroy the game object
            print(numBricks);
            lm.BrickDestroyed();
        }
        else { loadSprite(); } 
	}

    void createSmoke() {
        GameObject smokePuff = Instantiate(smoke, transform.position, Quaternion.identity);
        ParticleSystem.MainModule sm = smokePuff.GetComponent<ParticleSystem>().main;
        sm.startColor = gameObject.GetComponent<SpriteRenderer>().color;
    }

	void loadSprite() {
		int spriteIndex = numHits - 1;

        if (hitSprites[spriteIndex]) { //if sprite has something in it's index
            this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];   // go to spriterender in the brick inspector and
        }																		//go to the sprite section and changes its value
        else Debug.LogError("Sprite does not exist");
	}

  

	void simulateWin(){
		lm.LoadNextLevel();
	}
}
