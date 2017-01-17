using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	private bool hasStarted = false;
	private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>(); //finds object of type paddle when the game starts
		paddleToBallVector = this.transform.position - paddle.transform.position; //difference betwen the 3 positions (x, y, and z) of the ball and paddle;
	
	}
	
	// Update is called once per frame
	void Update () {
        if (!hasStarted){
			this.transform.position = paddle.transform.position + paddleToBallVector;
		if (Input.GetMouseButtonDown(0)) {
			hasStarted = true;
			this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
            }
            }
	    }

    private void OnCollisionEnter2D(Collision2D collision) {

        Vector2 ballphys = new Vector2(Random.Range(0f, 0.2f), Random.Range(0f, 0.2f)); //create a random vector2 ranging from 0-0.2 for both x and y coordinates
        
        AudioSource audio = GameObject.FindObjectOfType<AudioSource>(); //Our ball object has 
        if (hasStarted) {
            audio.Play();
           GetComponent<Rigidbody2D>().velocity += ballphys; //use getcomponent of our rigid 2d body and change it's velocity by the ballphys
        }
       
    }
}