using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 paddleVector = new Vector3 (0.5f, this.transform.position.y, 0);

		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;

		paddleVector.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f);

		this.transform.position= paddleVector; //this is the instance of current script

	}
}
